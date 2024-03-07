using QuizGame.Infrastructure.Data.Enums;

namespace QuizGame.Core.Contracts
{
    public interface IQuizService
    {
        Task CreateQuizAsync(int authorId, QuestionType questionType, string question);
    }
}
