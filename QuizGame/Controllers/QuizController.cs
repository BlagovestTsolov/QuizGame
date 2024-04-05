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

        private string GetUserId()
            => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
