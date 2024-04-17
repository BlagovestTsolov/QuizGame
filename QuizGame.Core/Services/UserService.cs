using Microsoft.AspNetCore.Identity;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.User;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository _repository)
        {
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
