using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Data.Seed;

namespace QuizGame.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            if (!Database.IsRelational())
            {
                Database.EnsureCreated();
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new QuestionTypeConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new QuizConfiguration());
            builder.ApplyConfiguration(new TriviaConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Quiz> Quizzes { get; set; } = null!;
        public DbSet<QuestionType> QuestionTypes { get; set; } = null!;
        public DbSet<Trivia> Trivias { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}
