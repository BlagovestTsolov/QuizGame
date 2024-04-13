using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;

namespace QuizGame.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;
        private readonly IAuthorService authorService;

        public UserController(IUserService _userService, 
            IAuthorService _authorService)
        {
            userService = _userService;
            authorService = _authorService;

        }

        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsersAsync();

            if (users == null || users.Count == 0)
            {
                return BadRequest();
            }

            foreach (var user in users)
            {
                user.IsAuthor = await authorService.AuthorExistsByIdAsync(user.Id);
            }

            return View(users);
        }
    }
}
