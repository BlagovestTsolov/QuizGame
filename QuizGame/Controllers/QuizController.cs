using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Quiz;
using System.Security.Claims;

namespace QuizGame.Controllers
{
    public class QuizController : BaseController
    {
        private readonly IQuizService quizService;
        private readonly IAuthorService authorService;

        public QuizController(IQuizService _quizService, IAuthorService _authorService)
        {
            quizService = _quizService;
            authorService = _authorService;
        }

        public async Task<IActionResult> All()
        {
            var res = await quizService.AllAsync();

            if (res == null)
            {
                return BadRequest();
            }

            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddQuizModel();
            model.QuestionTypes = await quizService.GetQuestionTypesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddQuizModel model)
        {
            if (!ModelState.IsValid)
            {
                model.QuestionTypes = await quizService.GetQuestionTypesAsync();

                return View(model);
            }

            model.AuthorId = await authorService.GetAuthorIdAsync(GetUserId());

            if (model.AuthorId == 0)
            {
                return BadRequest();
            }
            if (await quizService.QuestionExistsAsync(model.Question))
            {
                return BadRequest();
            }

            await quizService.CreateQuizAsync(model);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await quizService.DeleteQuizAsync(id);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await quizService.DetailsAsync(id);

            if (model.Author == null)
            {
                return BadRequest();
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await quizService.ExistsAsync(id);
            int authorId = await authorService.GetAuthorIdAsync(GetUserId());

            if (entity == null)
            {
                return BadRequest();
            }
            if (authorId == 0)
            {
                return BadRequest();
            }
            if (entity.AuthorId != authorId)
            {
                return Unauthorized();
            }

            AddQuizModel model = new()
            {
                AuthorId = entity.AuthorId,
                Question = entity.Question,
                Answer = entity.Answer,
                QuestionTypeId = entity.QuestionTypeId,
            };
            model.QuestionTypes = await quizService.GetQuestionTypesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AddQuizModel model)
        {
            int authorId = await authorService.GetAuthorIdAsync(GetUserId());

            if (!ModelState.IsValid)
            {
                model.QuestionTypes = await quizService.GetQuestionTypesAsync();

                return View(model);
            }
            if (authorId == 0)
            {
                return BadRequest();
            }
            if (model.AuthorId != authorId)
            {
                return Unauthorized();
            }

            model.AuthorId = authorId;

            await quizService.EditAsync(model);
            return RedirectToAction(nameof(All));
        }

        private string GetUserId()
            => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
