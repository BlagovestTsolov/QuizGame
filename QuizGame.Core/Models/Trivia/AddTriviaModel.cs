using QuizGame.Core.Models.Category;
using QuizGame.Core.Models.QuizType;
using System.ComponentModel.DataAnnotations;
using static QuizGame.Infrastructure.Data.Constants.DataConstants;
using static QuizGame.Infrastructure.ErrorMessages.ErrorMessages;

namespace QuizGame.Core.Models.Trivia
{
    public class AddTriviaModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(TriviaConstants.CommentMaxLength,
            MinimumLength = TriviaConstants.CommentMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Comment { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int CategoryId { get; set; }

        public IList<CategoryModel> Categories = new List<CategoryModel>();
    }
}
