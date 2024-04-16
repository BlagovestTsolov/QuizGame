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
    }
}
