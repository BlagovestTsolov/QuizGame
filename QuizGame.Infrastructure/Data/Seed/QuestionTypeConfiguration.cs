using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class QuestionTypeConfiguration : IEntityTypeConfiguration<QuestionType>
    {
        public void Configure(EntityTypeBuilder<QuestionType> builder)
        {
            var data = new SeedData();

            builder.HasData(new QuestionType[] { data.HistoryQuestionType,
                data.BiologyQuestionType, data.LiteratureQuestionType });
        }
    }
}