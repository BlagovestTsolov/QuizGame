using QuizGame.Core.Models.User;

namespace QuizGame.Core.Contracts
{
    public interface IUserService
    {
        public Task<IList<UserDto>> GetAllUsersAsync();
    }
}
