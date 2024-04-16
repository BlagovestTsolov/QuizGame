using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.Trivia;
using QuizGame.Core.Services;
using System.Security.Claims;

namespace QuizGame.Controllers
{
    public class TriviaController : BaseController
    {
        private readonly IAuthorService authorService;
        private readonly ITriviaService triviaService;

        public TriviaController(IAuthorService _authorService,
            ITriviaService _triviaService)
        {
            authorService = _authorService;
            triviaService = _triviaService;
        }

        public async Task<IActionResult> All()
        {
            var res = await triviaService.AllAsync();

            if (res == null)
            {
                return BadRequest();
            }

            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddTriviaModel();
            model.Categories = await triviaService.GetCategoriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTriviaModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await triviaService.GetCategoriesAsync();

                return View(model);
            }

            model.AuthorId = await authorService.GetAuthorIdAsync(User.Id());

            if (model.AuthorId == 0)
            {
                return BadRequest();
            }
            if (await triviaService.CommentExistsAsync(model.Comment))
            {
                return BadRequest();
            }

            await triviaService.CreateTriviaAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await triviaService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }
            if (await authorService.AuthorExistsByIdAsync(User.Id()) == false)
            {
                return BadRequest();
            }

            if (await triviaService.IsAuthorOfTriviaAsync(User.Id(), id) == false &&
                User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            var model = await triviaService.FillModelAsync(id);
            if (model == null)
            {
                return BadRequest();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddTriviaModel model, int id)
        {
            int authorId = await authorService.GetAuthorIdAsync(User.Id());

            if (!ModelState.IsValid)
            {
                model.Categories = await triviaService.GetCategoriesAsync();

                return View(model);
            }
            if (authorId == 0)
            {
                return BadRequest();
            }
            if (model.AuthorId != authorId && User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            model.AuthorId = authorId;

            await triviaService.EditAsync(model, id);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await triviaService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await triviaService.IsAuthorOfTriviaAsync(User.Id(), id) == false &&
                User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            int authorId = await triviaService.DeleteTriviaAsync(id);
            await authorService.DeleteAuthorAsync(authorId);

            return RedirectToAction(nameof(All));
        }
    }
}
