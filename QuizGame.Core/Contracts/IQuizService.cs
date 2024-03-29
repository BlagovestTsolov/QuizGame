using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.QuizType;

namespace QuizGame.Core.Contracts
{
    public interface IQuizService
    {
        Task CreateQuizAsync(AddQuizModel model);

        Task<IList<QuizDto>> AllAsync();

        public Task<List<QuestionTypeModel>> GetQuestionTypesAsync();
    }
}
