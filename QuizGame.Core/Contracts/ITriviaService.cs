using QuizGame.Core.Models.Category;
using QuizGame.Core.Models.Trivia;

namespace QuizGame.Core.Contracts
{
    public interface ITriviaService
    {
        Task<bool> ExistsAsync(int id);

        Task<IList<TriviaDto>> AllAsync();

        Task CreateTriviaAsync(AddTriviaModel model);

        Task<List<CategoryModel>> GetCategoriesAsync();

        Task<bool> CommentExistsAsync(string comment);

        Task EditAsync(AddTriviaModel model, int id);

        Task<int> DeleteTriviaAsync(int id);

        Task<bool> IsAuthorOfTriviaAsync(string userId, int triviaId);

        Task<AddTriviaModel?> FillModelAsync(int triviaId);
    }
}
