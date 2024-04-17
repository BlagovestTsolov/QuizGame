using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Category;
using QuizGame.Core.Models.Quiz;
using QuizGame.Core.Models.QuizType;
using QuizGame.Core.Models.Trivia;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class TriviaService : ITriviaService
    {
        private readonly IRepository repository;
        private readonly IAuthorService authorService;

        public TriviaService(IRepository _repository,
            IAuthorService _authorService)
        {
            repository = _repository;
            authorService = _authorService;

        }

        public async Task<IList<TriviaDto>> AllAsync()
        {
            var trivias = await repository.TriviasWithAuthorsReadOnlyAsync();

            var result = trivias.Select(t => new TriviaDto
            {
                Id = t.Id,
                Author = t.Author.User.UserName,
                Category = t.Category.Name,
                Comment = t.Comment
            })
            .ToList();

            return result;
        }

        public async Task CreateTriviaAsync(AddTriviaModel model)
        {
            await repository.AddAsync<Trivia>(new()
            {
                AuthorId = model.AuthorId,
                CategoryId = model.CategoryId,
                Comment = model.Comment
            });
            await repository.SaveChangesAsync();
        }

        public async Task<int> DeleteTriviaAsync(int id)
        {
            Trivia? trivia = (await repository.AllReadOnlyAsync<Trivia>())
                .FirstOrDefault(t => t.Id == id);

            if (trivia == null)
            {
                return 0;
            }

            int authorId = trivia.AuthorId;
            Author? author = (await repository.AllReadOnlyAsync<Author>())
                .FirstOrDefault(a => a.Id == authorId);

            await repository.DeleteAsync<Trivia>(id);

            await repository.SaveChangesAsync();

            return authorId;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var trivia = (await repository.AllReadOnlyAsync<Trivia>())
                .FirstOrDefault(t => t.Id == id);

            if (trivia == null)
            {
                return false;
            }

            return true;
        }

        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var categories = await repository.AllReadOnlyAsync<Category>();

            var result = categories.Select(s => new CategoryModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();

            return result;
        }

        public async Task<bool> IsAuthorOfTriviaAsync(string userId, int triviaId)
        {
            int authorId = await authorService.GetAuthorIdAsync(userId);
            var trivia = (await repository.AllReadOnlyAsync<Trivia>())
                .FirstOrDefault(t => t.Id == triviaId);

            if (trivia == null || trivia.AuthorId != authorId)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> CommentExistsAsync(string comment)
            => (await repository.AllReadOnlyAsync<Trivia>())
                .Any(q => q.Comment == comment);

        public async Task EditAsync(AddTriviaModel model, int id)
        {
            Trivia trivia = new()
            {
                AuthorId = model.AuthorId,
                Comment = model.Comment,
                CategoryId = model.CategoryId
            };

            await repository.DeleteAsync<Trivia>(id);
            await repository.AddAsync(trivia);

            await repository.SaveChangesAsync();
        }

        public async Task<AddTriviaModel?> FillModelAsync(int triviaId)
        {
            var trivia = (await repository.AllReadOnlyAsync<Trivia>())
                .FirstOrDefault(q => q.Id == triviaId);

            if (trivia == null)
            {
                return null;
            }

            AddTriviaModel model = new()
            {
                AuthorId = trivia.AuthorId,
                Comment = trivia.Comment,
                CategoryId = trivia.CategoryId,
            };
            model.Categories = await GetCategoriesAsync();

            return model;
        }
    }
}
