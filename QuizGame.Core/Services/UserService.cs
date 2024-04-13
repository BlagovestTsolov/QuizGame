using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.User;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IRepository repository;

        public UserService(UserManager<IdentityUser> _userManager,
            IRepository _repository)
        {
            userManager = _userManager;
            repository = _repository;
        }

        public async Task<IList<UserDto>> GetAllUsersAsync()
            => (await repository.AllReadOnlyAsync<IdentityUser>())
                .Select(u => new UserDto()
                {
                    Id = u.Id,
                    Email = u.Email
                })
                .ToList();
    }
}
