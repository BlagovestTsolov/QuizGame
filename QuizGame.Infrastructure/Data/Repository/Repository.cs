using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using QuizGame.Infrastructure.Data.Models;

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

        public async Task<IList<Quiz>> QuizzesWithAuthorsReadOnlyAsync() 
            => await context.Quizzes
            .Include(q => q.QuestionType)
            .Include(q => q.Author)
            .ThenInclude(a => a.User)
            .AsNoTracking()
            .ToListAsync();

        public async Task AddAsync<T>(T entity) where T : class
            => await context.AddAsync(entity);

        public async Task SaveChangesAsync()
            => await context.SaveChangesAsync();

        public async Task<T?> GetByIdAsync<T>(object id) where T : class
            => await context.Set<T>().FindAsync(id);

        public async Task DeleteAsync<T>(int id) where T : class
        {
            T? entity = await GetByIdAsync<T>(id);

            if (entity != null)
            {
                context.Remove(entity);
            }
        }

        public async Task<IList<Trivia>> TriviasWithAuthorsReadOnlyAsync()
            => await context.Trivias
            .Include(t => t.Category)
            .Include(t => t.Author)
            .ThenInclude(a => a.User)
            .AsNoTracking()
            .ToListAsync();
    }
}
