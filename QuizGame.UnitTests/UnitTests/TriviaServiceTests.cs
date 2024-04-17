using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Trivia;
using QuizGame.Core.Services;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.UnitTests.Mocks;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class TriviaServiceTests : UnitTestsBase
    {
        private ITriviaService triviaService;
        private IAuthorService authorService;

        [SetUp]
        public void SetUp()
        {
            triviaService = new TriviaService(context, new AuthorService(context));

            context = DatabaseMock.Instance;
            SeedDatabase();
        }

        [Test]
        public async Task ExistsAsync_ShouldReturnCorrectData()
        {
            var result = await triviaService.ExistsAsync(Trivia.Id);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task IsAuthorOfTriviaAsync_ShouldReturnCorrectData()
        {
            var result = await triviaService.IsAuthorOfTriviaAsync(Author.UserId, Trivia.Id);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task CommentExistsAsync_ShouldReturnCorrectData()
        {
            var result = await triviaService.CommentExistsAsync(Trivia.Comment);
            Assert.That(result, Is.True);
        }

        [Test]
        public async Task FillModelAsync_ShouldReturnCorrectData()
        {
            var result = await triviaService.FillModelAsync(Trivia.Id);

            Assert.That(result!.Comment, Is.EqualTo(Trivia.Comment));
        }

        [Test]
        public async Task CreateTriviaAsync_ShouldReturnCorrectData()
        {
            var dbTriviasBefore = (await context.AllReadOnlyAsync<Trivia>()).Count();

            var newTrivia = new Trivia
            {
                Comment = "new comment",
            };

            await triviaService.CreateTriviaAsync(new AddTriviaModel
            {
                Comment = newTrivia.Comment,
            });

            var dbTriviasAfter = (await context.AllReadOnlyAsync<Trivia>()).Count();
            dbTriviasBefore++;
            Assert.That(dbTriviasBefore, Is.EqualTo(dbTriviasAfter));
        }

        [Test]
        public async Task EditAsync_ShouldReturnCorrectData()
        {
            await triviaService.EditAsync(new AddTriviaModel
            {
                AuthorId = Trivia.AuthorId,
                Comment = "edited comment",
                CategoryId = Trivia.CategoryId
            }, Trivia.Id);

            var trivia = (await context.AllReadOnlyAsync<Trivia>())
                .First();

            Assert.That(trivia.Comment, Is.EqualTo("edited comment"));
        }

        [Test]
        public async Task DeleteTriviaAsync_ShouldReturnCorrectData()
        {
            var expectedAuthorId = Trivia.AuthorId;
            var actualAuthorId = await triviaService.DeleteTriviaAsync(Trivia.Id);

            Assert.That(expectedAuthorId, Is.EqualTo(actualAuthorId));
        }


        [Test]
        public async Task GetCategoriesAsync_ShouldReturnCorrectData()
        {
            var result = await triviaService.GetCategoriesAsync();
            var data = await context.AllReadOnlyAsync<Category>();

            Assert.That(result.Count(), Is.EqualTo(data.Count()));
        }
    }
}
