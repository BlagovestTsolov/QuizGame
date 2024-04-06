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

        Task DeleteQuizAsync(int id);

        Task<bool> QuestionExistsAsync(string question);

        Task<QuizDto> DetailsAsync(int id);

        Task<Quiz?> ExistsAsync(int id);

        Task EditAsync(AddQuizModel model);
    }
}
