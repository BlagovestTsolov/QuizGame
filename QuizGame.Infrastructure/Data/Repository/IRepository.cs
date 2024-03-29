namespace QuizGame.Infrastructure.Repository
{
    public interface IRepository
    {
        Task<IList<T>> AllAsync<T>() where T : class;

        Task<IList<T>> AllReadOnlyAsync<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(object id) where T : class;

        Task DeleteAsync<T>(int id) where T : class;
    }
}
