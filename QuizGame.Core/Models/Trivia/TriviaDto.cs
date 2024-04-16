namespace QuizGame.Core.Models.Trivia
{
    public class TriviaDto
    {
        public int Id { get; set; }

        public string Author { get; set; } = null!;

        public string Comment { get; set; } = null!;

        public string Category { get; set; } = null!;
    }
}
