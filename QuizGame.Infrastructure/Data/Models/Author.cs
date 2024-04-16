using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizGame.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IList<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public IList<Trivia> Trivias { get; set; } = new List<Trivia>();

    }
}