using Moq;
using QuizGame.Core.Contracts;
using QuizGame.Core.Services;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class AuthorServiceTests : UnitTestsBase
    {
        private IAuthorService authorService;
        private Mock<IRepository> repo;

        [OneTimeSetUp]
        public void SetUp()
        {
            //repo = new Mock<IRepository>();
            //repo.Setup(x => x.AddAsync(It.IsAny(new Quiz() 
            //{
            //    Id = 1,
            //    Author = Author,
            //    QuestionType = new QuestionType { Name = "History" },
            //    Question = "Question",
            //    Answer = "Answer"
            //})))
            //    .Returns();

            authorService = new AuthorService(repo.Object); 
        }

        [Test]
        public async Task GetAuthorIdAsync_ShouldReturnCorrectUserId()
        {
            var result = await authorService.GetAuthorIdAsync(Author.UserId);

            Assert.That(result, Is.EqualTo(Author.Id));
        }

        [Test]
        public async Task AuthorExistsByIdAsync_ShouldReturnCorrectOutput()
        {
            var result = await authorService.AuthorExistsByIdAsync(Author.UserId);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
