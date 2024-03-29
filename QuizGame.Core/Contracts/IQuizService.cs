using QuizGame.Core.Models.Quiz;

namespace QuizGame.Core.Contracts
{
    public interface IQuizService
    {
        Task CreateQuizAsync(AddQuizModel model);

        Task<IList<QuizDto>> AllAsync();
    }
}
