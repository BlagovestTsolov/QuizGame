namespace QuizGame.Core.Models.User
{
    public class UserDto
    {
        public string Id { get; set; } = null!;

        public bool IsAuthor { get; set; }

        public string Email { get; set; } = null!;
    }
}
