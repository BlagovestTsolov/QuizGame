using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.QuizType;

namespace QuizGame.Core.Contracts
{
    public interface IQuizService
    {
        Task CreateQuizAsync(AddQuizModel model);

        Task<IList<QuizDto>> AllAsync();

        Task<List<QuestionTypeModel>> GetQuestionTypesAsync();

        Task DeleteQuizAsync(int id);
    }
}
