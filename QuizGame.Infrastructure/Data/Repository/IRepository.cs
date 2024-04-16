using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Repository
{
    public interface IRepository
    {
        Task<IList<T>> AllAsync<T>() where T : class;

        Task<IList<T>> AllReadOnlyAsync<T>() where T : class;

        Task<IList<Quiz>> QuizzesWithAuthorsReadOnlyAsync();

        Task<IList<Trivia>> TriviasWithAuthorsReadOnlyAsync();

        Task<IList<Author>> AuthorsWithQuizzesAndTrivias();

        Task AddAsync<T>(T entity) where T : class;

        Task SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(object id) where T : class;

        Task DeleteAsync<T>(int id) where T : class;
    }
}
