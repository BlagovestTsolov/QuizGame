using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;

namespace QuizGame.Areas.Admin.Controllers
{
    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsersAsync();

            return View(users);
        }
    }
}
