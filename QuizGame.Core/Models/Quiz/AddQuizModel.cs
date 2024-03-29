using System.ComponentModel.DataAnnotations;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;
using static QuizGame.Infrastructure.ErrorMessages.ErrorMessages;

namespace QuizGame.Core.Models.Quiz
{
    public class AddQuizModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(QuestionTypeConstants.QuizTypeMaxLength,
            MinimumLength = QuestionTypeConstants.QuizTypeMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string QuestionType { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(QuizConstants.QuestionMaxLength,
            MinimumLength = QuizConstants.QuestionMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Question { get; set; } = null!;
    }
}
