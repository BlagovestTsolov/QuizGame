using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Trivia
    {
        [Key]
        [Comment("Trivia Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Category Identifier")]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        [Comment("Category")]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Author Identifier")]
        public int AuthorId { get; set; }

        [Required]
        [Comment("Author")]
        public Author Author { get; set; } = null!;

        [Required]
        [MaxLength(TriviaConstants.CommentMaxLength)]
        [Comment("Comment")]
        public string Comment { get; set; } = null!;
    }
}
