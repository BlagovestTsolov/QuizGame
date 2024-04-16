using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] { data.TechCategory,
                data.PoliticCategory, data.SportCategory });
        }
    }
}
