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
            if (await authorService.AuthorExistsByIdAsync(GetUserId()))
            {
                return BadRequest();
            }

            await authorService.BecomeAuthorAsync(GetUserId());

            return RedirectToAction(nameof(QuizController.All), "Quiz");
        }

        private string GetUserId()
            => User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
