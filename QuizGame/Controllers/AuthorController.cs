using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;
using System.Security.Claims;

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
            if (await authorService.AuthorExistsByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            await authorService.BecomeAuthorAsync(User.Id());

            return View();
        }
    }
}
