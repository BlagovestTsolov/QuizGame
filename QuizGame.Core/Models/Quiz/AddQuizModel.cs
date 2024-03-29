using QuizGame.Core.Models.QuizType;
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
        [StringLength(QuizConstants.QuestionMaxLength,
            MinimumLength = QuizConstants.QuestionMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Question { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int QuestionTypeId { get; set; }

        public IList<QuestionTypeModel> QuestionTypes = new List<QuestionTypeModel>();
    }
}
