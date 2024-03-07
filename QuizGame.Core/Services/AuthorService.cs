using QuizGame.Core.Contracts;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository repository;

        public AuthorService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<int> GetAuthorIdAsync(string userId)
        {
            int result;

            var id = (await repository.AllReadOnlyAsync<Author>())
                .FirstOrDefault(a => a.UserId == userId)?.Id;

            if (id == null)
            {
                result = 0;
            }
            else
            {
                result = id.Value;
            }

            return result;
        }

        public async Task CreateAsync(string userId)
        {
            await repository.AddAsync<Author>(new()
            {
                UserId = userId,
            });
            await repository.SaveChangesAsync();
        }
    }
}
