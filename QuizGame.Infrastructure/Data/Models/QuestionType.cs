using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;

namespace QuizGame.Infrastructure.Data.Models
{
    public class QuestionType
    {
        [Key]
        [Comment("Quiz type Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(QuestionTypeConstants.QuizTypeMaxLength)]
        [Comment("Quiz type name")]
        public string Name { get; set; } = null!;

        public IList<Quiz> Quizzes { get; set; } = new List<Quiz>();
    }
}
