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

        public Category TechCategory { get; set; }

        public Category PoliticCategory { get; set; }

        public Category SportCategory { get; set; }

        public Quiz FirstQuiz { get; set; }

        public Quiz SecondQuiz { get; set; }

        public Quiz ThirdQuiz { get; set; }

        public Trivia FirstTrivia { get; set; }

        public Trivia SecondTrivia { get; set; }

        public Trivia ThirdTrivia { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedAuthors();
            SeedQuestionTypes();
            SeedCategories();
            SeedQuizzes();
            SeedTrivias();
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

        private void SeedCategories()
        {
            TechCategory = new Category()
            {
                Id = 1,
                Name = "Tech"
            };

            PoliticCategory = new Category()
            {
                Id = 2,
                Name = "Politics"
            };

            SportCategory = new Category()
            {
                Id = 3,
                Name = "Sports"
            };
        }

        private void SeedQuizzes()
        {
            FirstQuiz = new Quiz()
            {
                Id = 1,
                Question = "Каква е ролята на Кирил и Методий за развитието на българската култура?",
                Answer = "Те са създатели на славянската писменост, преводачи на богослужебни книги, проповедници на християнството и основоположници на българската литература.",
                QuestionTypeId = HistoryQuestionType.Id,
                AuthorId = Author.Id,
            };

            SecondQuiz = new Quiz()
            {
                Id = 2,
                Question = "Какъв е процесът на фотосинтеза и каква е неговата роля за живите организми?",
                Answer = "Фотосинтезата е процес, при който слънчевата светлина се превръща в химическа енергия, съхранена в глюкоза. Този процес се осъществява от фотосинтезиращи организми, като растения, водорасли и някои бактерии.",
                QuestionTypeId = BiologyQuestionType.Id,
                AuthorId = Author.Id
            };

            ThirdQuiz = new Quiz()
            {
                Id = 3,
                Question = "Кои са трите основни периода в развитието на българската литература?",
                Answer = "Трите основни периода в развитието на българската литература са: Старобългарска литература (IX-XVIII век), Възрожденска литература (XVIII-XIX век) и Съвременна българска литература (XIX-XXI век)",
                QuestionTypeId = LiteratureQuestionType.Id,
                AuthorId = Author.Id
            };
        }

        private void SeedTrivias()
        {
            FirstTrivia = new Trivia()
            {
                Id = 1,
                Comment = "Няколко български компании разработват AI и ML решения за различни индустрии, като здравеопазване, финанси, селско стопанство и производство.",
                CategoryId = TechCategory.Id,
                AuthorId = Author.Id,
            };

            SecondTrivia = new Trivia()
            {
                Id = 2,
                Comment = "Българската политика е сравнително динамична и многопартийна, с множество политически партии, които се борят за влияние.",
                CategoryId = PoliticCategory.Id,
                AuthorId = Author.Id,
            };

            ThirdTrivia = new Trivia()
            {
                Id = 3,
                Comment = "Григор Димитров: Най-успешният български тенисист, класирал се до №3 в световната ранглиста за мъже. Печелил е ATP Finals през 2018 г. и е участвал на полуфинал на Уимбълдън през 2014 г.",
                CategoryId = SportCategory.Id,
                AuthorId = Author.Id,
            };
        }
    }
}
