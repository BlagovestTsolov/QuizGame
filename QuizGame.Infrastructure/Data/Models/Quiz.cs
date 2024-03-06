using Microsoft.AspNetCore.Identity;
using QuizGame.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public IdentityUser Author { get; set; } = null!;

        public QuestionType QuestionType { get; set; }

        public string Question { get; set; } = null!;
    }
}
