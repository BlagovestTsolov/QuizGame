using Microsoft.AspNetCore.Mvc;

namespace QuizGame.Controllers
{
    public class AuthorController : BaseController
    {
        public async Task<IActionResult> Become()
        {
            return View();
        }
    }
}
