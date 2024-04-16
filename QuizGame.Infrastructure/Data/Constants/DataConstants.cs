namespace QuizGame.Infrastructure.Data.Constants
{
    public class DataConstants
    {
        public class QuizConstants
        {
            public const int QuestionMaxLength = 100;
            public const int QuestionMinLength = 15;

            public const int AnswerMaxLength = 500;
            public const int AnswerMinLenth = 3;
        }

        public class QuestionTypeConstants
        {
            public const int QuizTypeMaxLength = 20;
            public const int QuizTypeMinLength = 2;
        }
        
        public class CategoryConstants
        {
            public const int CategoryMaxLength = 20;
            public const int CategoryMinLength = 2;
        }
        
        public class TriviaConstants
        {
            public const int CommentMaxLength = 300;
            public const int CommentMinLength = 10;
        }
    }
}
