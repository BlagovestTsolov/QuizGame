using QuizGame.Core.Contracts;
using QuizGame.Core.Services;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class AuthorServiceTests : UnitTestsBase
    {
        private IAuthorService authorService;

        [OneTimeSetUp]
        public void SetUp()
            => authorService = new AuthorService(context);

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
