using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuizGame.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Quiz
    {
        [Key]
        [Comment("Quiz Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Author")]
        public Author Author { get; set; } = null!;

        [Required]
        [Comment("Question Type")]
        public QuestionType QuestionType { get; set; }

        [Required]
        [MaxLength(QuizConstants.QuestionMaxLength)]
        [Comment("Question")]
        public string Question { get; set; } = null!;
    }
}
