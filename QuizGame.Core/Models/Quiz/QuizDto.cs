namespace QuizGame.Core.Models.Quiz
{
    public class QuizDto
    {
        public string Author { get; set; } = null!;

        public string QuestionType { get; set; } = null!;

        public string Question { get; set; } = null!;
    }
}
