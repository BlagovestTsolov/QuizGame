using Microsoft.AspNetCore.Identity;
using QuizGame.Data;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;
using QuizGame.UnitTests.Mocks;

namespace QuizGame.UnitTests.UnitTests
{
    public class UnitTestsBase
    {
        protected IRepository context;

        public Author Author { get; set; }

        public Quiz Quiz { get; set; }

        public Trivia Trivia { get; set; }

        [OneTimeSetUp]
        public void Seed()
        {
            context = DatabaseMock.Instance;
            SeedDatabase();
        }

        protected async Task SeedDatabase()
        {
            Author = new Author()
            {
                Id = 1,
                UserId = "AuthorId"
            };

            await context.AddAsync(Author);

            Quiz = new Quiz()
            {
                Id = 1,
                Author = Author,
                QuestionType = new QuestionType { Name = "History" },
                Question = "Question",
                Answer = "Answer"
            };

            await context.AddAsync(Quiz);
            
            Trivia = new Trivia()
            {
                Id = 1,
                Author = Author,
                Category = new Category { Name = "Tech" },
                Comment = "Comment"
            };

            await context.AddAsync(Trivia);
            await context.SaveChangesAsync();
        }
    }
}
