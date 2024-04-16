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
            var id = (await repository.AllReadOnlyAsync<Author>())
                .FirstOrDefault(a => a.UserId == userId)?.Id;

            return id ?? 0;
        }

        public async Task BecomeAuthorAsync(string userId)
        {
            await repository.AddAsync<Author>(new()
            {
                UserId = userId,
            });
            await repository.SaveChangesAsync();
        }

        public async Task<bool> AuthorExistsByIdAsync(string userId)
        {
            var authors = await repository.AllReadOnlyAsync<Author>();
            return authors.Any(a => a.UserId == userId);
        }

        public async Task DeleteAuthorAsync(int authorId)
        {
            if (authorId == 0)
            {
                return;
            }

            Author? author = (await repository.AuthorsWithQuizzesAndTrivias())
                .FirstOrDefault(a => a.Id == authorId);

            if (author == null)
            {
                return;
            }

            if (author.Quizzes.Count == 0 && author.Trivias.Count == 0)
            {
                await repository.DeleteAsync<Author>(authorId);
                await repository.SaveChangesAsync();
            }
        }
    }
}
