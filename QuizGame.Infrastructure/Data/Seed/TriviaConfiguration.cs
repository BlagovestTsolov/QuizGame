using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class TriviaConfiguration : IEntityTypeConfiguration<Trivia>
    {
        public void Configure(EntityTypeBuilder<Trivia> builder)
        {
            var data = new SeedData();

            builder.HasData(new Trivia[] 
            { data.FirstTrivia, data.SecondTrivia, data.ThirdTrivia });
        }
    }
}
