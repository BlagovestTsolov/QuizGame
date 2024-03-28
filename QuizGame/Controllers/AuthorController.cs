using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;

namespace QuizGame.Controllers
{
    public class AuthorController : BaseController
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService _authorService)
        {
            authorService = _authorService;
        }

        public async Task<IActionResult> Become()
        {
            return View();
        }
    }
}
