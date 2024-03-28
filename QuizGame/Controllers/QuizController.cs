using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;

namespace QuizGame.Controllers
{
    public class QuizController : BaseController
    {
        private readonly IQuizService quizService;

        public QuizController(IQuizService _quizService)
        {
            quizService = _quizService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
