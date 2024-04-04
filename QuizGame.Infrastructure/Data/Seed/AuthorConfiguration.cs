using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            var data = new SeedData();

            builder.HasData(new Author[] { data.Author, data.AdminAuthor });
        }
    }
}
