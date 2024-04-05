namespace QuizGame.Core.Contracts
{
    public interface IAuthorService
    {
        Task<int> GetAuthorIdAsync(string userId);

        Task BecomeAuthorAsync (string userId);

        Task<bool> AuthorExistsByIdAsync(string userId);
    }
}
