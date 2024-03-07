using Microsoft.AspNetCore.Mvc;

namespace QuizGame.Controllers
{
    public class QuizController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
