using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryConstants.CategoryMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = null!;

        public IList<Trivia> Trivias { get; set; } = new List<Trivia>();
    }
}
