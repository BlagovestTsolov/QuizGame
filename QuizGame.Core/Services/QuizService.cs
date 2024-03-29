using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.QuizType;
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

        public async Task CreateQuizAsync(AddQuizModel model)
        {
            await repository.AddAsync<Quiz>(new()
            {
                AuthorId = model.AuthorId,
                //QuestionType = model.QuestionType,
                Question = model.Question
            });
            await repository.SaveChangesAsync();
        }

        public async Task<IList<QuizDto>> AllAsync()
        {
            var set = await repository.AllReadOnlyAsync<Quiz>();

            var result = set.Select(q => new QuizDto
            {
                Author = q.Author.User.UserName,
                QuestionType = q.QuestionType.ToString(),
                Question = q.Question
            })
            .ToList();

            return result;
        }

        public async Task<List<QuestionTypeModel>> GetQuestionTypesAsync()
        {
            var set = await repository.AllReadOnlyAsync<QuestionType>();

            var result = set.Select(s => new QuestionTypeModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();

            return result;
        }
    }
}
