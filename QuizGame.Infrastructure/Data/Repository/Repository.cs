using Microsoft.EntityFrameworkCore;
using QuizGame.Data;

namespace QuizGame.Infrastructure.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task<IList<T>> AllAsync<T>() where T : class
            => await context.Set<T>().ToListAsync();

        public async Task<IList<T>> AllReadOnlyAsync<T>() where T : class
            => await context.Set<T>().AsNoTracking().ToListAsync();

        public async Task AddAsync<T>(T entity) where T : class
            => await context.AddAsync(entity);

        public async Task SaveChangesAsync()
            => await context.SaveChangesAsync();
    }
}
