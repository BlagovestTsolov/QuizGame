namespace QuizGame.Core.Contracts
{
    public interface IAuthorService
    {
        Task<int> GetAuthorIdAsync(string userId);

        Task CreateAsync(string userId);
    }
}
