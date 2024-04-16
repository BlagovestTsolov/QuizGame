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
        private readonly IAuthorService authorService;

        public QuizService(IRepository _repository,
            IAuthorService _authorService)
        {
            repository = _repository;
            authorService = _authorService;
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

        public async Task<int> DeleteQuizAsync(int id)
        {
            Quiz? quiz = (await repository.AllReadOnlyAsync<Quiz>())
                .FirstOrDefault(q => q.Id == id);

            if (quiz == null)
            {
                return 0;
            }

            int authorId = quiz.AuthorId;
            Author? author = (await repository.AllReadOnlyAsync<Author>())
                .FirstOrDefault(a => a.Id == authorId);

            await repository.DeleteAsync<Quiz>(id);

            await repository.SaveChangesAsync();

            return authorId;
        }

        public async Task<bool> QuestionExistsAsync(string question)
            => (await repository.AllReadOnlyAsync<Quiz>())
                .Any(q => q.Question == question);

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

        public async Task<bool> ExistsAsync(int id)
        {
            var quiz = (await repository.AllReadOnlyAsync<Quiz>())
                .FirstOrDefault(e => e.Id == id);

            if (quiz == null)
            {
                return false;
            }

            return true;
        }

        public async Task EditAsync(AddQuizModel model, int id)
        {
            Quiz quiz = new()
            {
                AuthorId = model.AuthorId,
                Question = model.Question,
                Answer = model.Answer,
                QuestionTypeId = model.QuestionTypeId
            };

            await repository.DeleteAsync<Quiz>(id);
            await repository.AddAsync(quiz);

            await repository.SaveChangesAsync();
        }

        public async Task<bool> IsAuthorOfQuizAsync(string userId, int quizId)
        {
            int authorId = await authorService.GetAuthorIdAsync(userId);
            var quiz = (await repository.AllReadOnlyAsync<Quiz>())
                .FirstOrDefault(q => q.Id == quizId);

            if (quiz == null || quiz.AuthorId != authorId)
            {
                return false;
            }

            return true;
        }

        public async Task<AddQuizModel?> FillModelAsync(int quizId)
        {
            var quiz = (await repository.AllReadOnlyAsync<Quiz>())
                .FirstOrDefault(q => q.Id == quizId);

            if (quiz == null)
            {
                return null;
            }

            AddQuizModel model = new()
            {
                AuthorId = quiz.AuthorId,
                Question = quiz.Question,
                Answer = quiz.Answer,
                QuestionTypeId = quiz.QuestionTypeId,
            };
            model.QuestionTypes = await GetQuestionTypesAsync();

            return model;
        }
    }
}