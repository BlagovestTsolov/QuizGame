using QuizGame.Core.Contracts;
using QuizGame.Infrastructure.Data.Enums;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class QuizService : IQuizService
    {
        private readonly IRepository repository;

        public QuizService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateQuizAsync(
            int authorId, 
            QuestionType questionType, 
            string question)
        {
            await repository.AddAsync<Quiz>(new()
            {
                AuthorId = authorId,
                QuestionType = questionType,
                Question = question
            });
            await repository.SaveChangesAsync();
        }
    }
}
