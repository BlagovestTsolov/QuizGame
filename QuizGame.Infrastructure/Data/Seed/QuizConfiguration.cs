using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder
                .HasOne(h => h.QuestionType)
                .WithMany(c => c.Quizzes)
                .HasForeignKey(h => h.QuestionTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(h => h.Author)
                .WithMany(a => a.Quizzes)
                .HasForeignKey(h => h.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            var data = new SeedData();

            builder.HasData(new Quiz[] { data.FirstQuiz, data.SecondQuiz, data.ThirdQuiz });
        }
    }
}
