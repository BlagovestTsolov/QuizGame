using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Quiz
    {
        [Key]
        [Comment("Quiz Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Author Identifier")]
        public int AuthorId { get; set; }

        [Required]
        [Comment("Author")]
        public Author Author { get; set; } = null!;

        [Required]
        [Comment("Question Type Identifier")]
        public int QuestionTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(QuestionTypeId))]
        [Comment("Question Type")]
        public QuestionType QuestionType { get; set; } = null!;

        [Required]
        [MaxLength(QuizConstants.QuestionMaxLength)]
        [Comment("Question")]
        public string Question { get; set; } = null!;
    }
}
