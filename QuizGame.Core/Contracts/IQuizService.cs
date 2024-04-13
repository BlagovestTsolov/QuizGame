using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.QuizType;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Core.Contracts
{
    public interface IQuizService
    {
        Task CreateQuizAsync(AddQuizModel model);

        Task<IList<QuizDto>> AllAsync();

        Task<List<QuestionTypeModel>> GetQuestionTypesAsync();

        Task<int> DeleteQuizAsync(int id);

        Task<bool> QuestionExistsAsync(string question);

        Task<QuizDto> DetailsAsync(int id);

        Task<bool> ExistsAsync(int id);

        Task EditAsync(AddQuizModel model, int id);

        Task<bool> IsAuthorOfQuizAsync(string userId, int quizId);

        Task<AddQuizModel?> FillModelAsync(int quizId);
    }
}
