﻿namespace QuizGame.Core.Models.Quiz
{
    public class QuizDto
    {
        public int Id { get; set; }

        public string Author { get; set; } = null!;

        public string Question { get; set; } = null!;

        public string Answer { get; set; } = null!;

        public string QuestionType { get; set; } = null!;
    }
}
