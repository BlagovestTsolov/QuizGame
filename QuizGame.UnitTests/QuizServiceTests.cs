using Microsoft.EntityFrameworkCore;
using Moq;
using QuizGame.Core.Contracts;
using QuizGame.Core.Services;
using QuizGame.Data;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.UnitTests
{
    [TestFixture]
    public class QuizServiceTests
    {
        //private IRepository repo;
        //private IAuthorService authorService;
        //private IQuizService quizService;
        //private ApplicationDbContext context;
        private readonly Mock<IRepository> mock;

        public QuizServiceTests()
        {
            mock = new Mock<IRepository>();
        }

        //[SetUp]
        //public void SetUp()
        //{
        //    var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
        //        .UseInMemoryDatabase("QuizDB")
        //        .Options;

        //    context = new ApplicationDbContext(contextOptions);

        //    context.Database.EnsureDeleted();
        //    context.Database.EnsureCreated();
        //}

        //[Test]
        //public async Task TestQuizEdit()
        //{
        //var repo = new Repository(context);
        //authorService = new AuthorService(repo);
        //quizService = new QuizService(repo, authorService);

        //await repo.AddAsync(new Quiz()
        //{
        //    Id = 1,
        //    AuthorId = 1,
        //    QuestionTypeId = 1,
        //    Question = "",
        //    Answer = ""
        //});

        //await repo.SaveChangesAsync();

        //await quizService.EditAsync(new AddQuizModel()
        //{
        //    AuthorId = 1,
        //    QuestionTypeId = 1,
        //    Question = "edited question",
        //    Answer = ""
        //}, 1);

        //var dbQuiz = await repo.GetByIdAsync<Quiz>(1);
        //Assert.That(dbQuiz.Question == "edited question");
        //}

        [Test]
        public async Task GetAllQuizzes_ReturnsExpectedQuizzes_WhenDataExists()
        {
            IList<Quiz> expectedQuizzes = new List<Quiz>()
            {
                new()
                {
                    Id = 1,
                    Question = "question 1",
                    Answer = "answer 1",
                    QuestionTypeId = 1,
                    AuthorId = 1,
                },
                new()
                {
                    Id = 2,
                    Question = "question 2",
                    Answer = "answer 2",
                    QuestionTypeId = 2,
                    AuthorId = 2,
                },
            };

            mock.Setup(repo => repo.AllAsync<Quiz>())
                .Returns(Task.FromResult(expectedQuizzes));
            //mock.Setup(repo => repo.QuizzesWithAuthorsReadOnlyAsync()
            //    Task.FromResult(GetExpectedQuizzes());

            //IQuizService quizService = 
            //    new QuizService(mock.Object, new AuthorService(mock.Object));
            //var actualQuizzes = await quizService.AllAsync();

            //Assert.Multiple(() =>
            //{
            //    Assert.That(expectedQuizzes.Count, Is.EqualTo(actualQuizzes.Count));
            //    Assert.That(actualQuizzes[0].Id == expectedQuizzes[0].Id
            //        && actualQuizzes[0].Question == expectedQuizzes[0].Question);
            //    Assert.That(actualQuizzes[1].Id == expectedQuizzes[1].Id
            //        && actualQuizzes[1].Question == expectedQuizzes[1].Question);
            //});
        }
    }
}
