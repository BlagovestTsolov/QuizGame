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
                QuestionTypeId = model.QuestionTypeId,
                Question = model.Question,
                Answer = model.Answer
            });
            await repository.SaveChangesAsync();
        }

        public async Task<IList<QuizDto>> AllAsync()
        {
            var quizzes = await repository.QuizzesWithAuthorsReadOnlyAsync();

            var result = quizzes.Select(q => new QuizDto
            {
                Id = q.Id,
                Author = q.Author.User.UserName,
                QuestionType = q.QuestionType.Name,
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

        public async Task DeleteQuizAsync(int id)
        {
            await repository.DeleteAsync<Quiz>(id);
            await repository.SaveChangesAsync();
        }

        public async Task<bool> QuestionExistsAsync(string question)
        {
            var quizzes = await repository.AllReadOnlyAsync<Quiz>();
            return quizzes.Any(q => q.Question == question);
        }

        public async Task<QuizDto> DetailsAsync(int id)
        {
            var set = await repository.QuizzesWithAuthorsReadOnlyAsync();
            var entity = set.FirstOrDefault(e => e.Id == id);

            QuizDto model = new();
            if (entity != null)
            {
                model.Author = entity.Author.User.UserName;
                model.Question = entity.Question;
                model.Answer = entity.Answer;
                model.QuestionType = entity.QuestionType.Name;
            }

            return model;
        }

        public async Task<Quiz?> ExistsAsync(int id)
        {
            var set = await repository.AllReadOnlyAsync<Quiz>();
            return set.FirstOrDefault(e => e.Id == id);
        }

        public async Task EditAsync(AddQuizModel model)
        {
            Quiz quiz = new()
            {
                AuthorId = model.AuthorId,
                Question = model.Question,
                Answer = model.Answer,
                QuestionTypeId = model.QuestionTypeId
            };

            await repository.AddAsync(quiz);
            await repository.SaveChangesAsync();
        }
    }
}