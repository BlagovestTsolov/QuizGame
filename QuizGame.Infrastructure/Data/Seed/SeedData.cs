using Microsoft.AspNetCore.Identity;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.Infrastructure.Data.Seed
{
    internal class SeedData
    {
        public IdentityUser AuthorUser { get; set; }

        public IdentityUser GuestUser { get; set; }

        public IdentityUser AdminUser { get; set; }

        public Author Author { get; set; }

        public Author AdminAuthor { get; set; }

        public QuestionType HistoryQuestionType { get; set; }

        public QuestionType BiologyQuestionType { get; set; }

        public QuestionType LiteratureQuestionType { get; set; }

        public Quiz FirstQuiz { get; set; }

        public Quiz SecondQuiz { get; set; }

        public Quiz ThirdQuiz { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedAuthors();
            SeedQuestionTypes();
            SeedQuizzes();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AuthorUser = new IdentityUser()
            {
                Id = "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                UserName = "author@mail.com",
                NormalizedUserName = "author@mail.com",
                Email = "author@mail.com",
                NormalizedEmail = "author@mail.com"
            };

            AuthorUser.PasswordHash =
                 hasher.HashPassword(AuthorUser, "author123");

            GuestUser = new IdentityUser()
            {
                Id = "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(AuthorUser, "guest123");

            AdminUser = new IdentityUser()
            {
                Id = "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "admin123");
        }

        private void SeedAuthors()
        {
            Author = new Author()
            {
                Id = 1,
                UserId = AuthorUser.Id
            };

            AdminAuthor = new Author()
            {
                Id = 2,
                UserId = AdminUser.Id
            };
        }

        private void SeedQuestionTypes()
        {
            HistoryQuestionType = new QuestionType()
            {
                Id = 1,
                Name = "History"
            };

            BiologyQuestionType = new QuestionType()
            {
                Id = 2,
                Name = "Biology"
            };

            LiteratureQuestionType = new QuestionType()
            {
                Id = 3,
                Name = "Literature"
            };
        }

        private void SeedQuizzes()
        {
            FirstQuiz = new Quiz()
            {
                Id = 1,
                Question = "Каква е ролята на Кирил и Методий за развитието на българската култура?",
                QuestionTypeId = HistoryQuestionType.Id,
                AuthorId = Author.Id,
            };

            SecondQuiz = new Quiz()
            {
                Id = 2,
                Question = "Какъв е процесът на фотосинтеза и каква е неговата роля за живите организми?",
                QuestionTypeId = BiologyQuestionType.Id,
                AuthorId = Author.Id
            };

            ThirdQuiz = new Quiz()
            {
                Id = 3,
                Question = "Кои са трите основни периода в развитието на българската литература?",
                QuestionTypeId = LiteratureQuestionType.Id,
                AuthorId = Author.Id
            };
        }
    }
}
