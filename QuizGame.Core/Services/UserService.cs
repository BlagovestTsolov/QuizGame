using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.User;

namespace QuizGame.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> userManager;

        public UserService(UserManager<IdentityUser> _userManager)
        {
            userManager = _userManager;
        }

        public async Task<IList<UserDto>> GetAllUsersAsync()
            => await userManager.Users
                .Select(u => new UserDto()
                {
                    Id = u.Id,
                    Email = u.Email
                })
                .ToListAsync();
    }
}
