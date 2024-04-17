using QuizGame.Core.Contracts;
using QuizGame.Core.Services;
using QuizGame.Infrastructure.Data.Models;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class StatisticServiceTests : UnitTestsBase
    {
        private IStatisticService statisticService;

        [OneTimeSetUp]
        public void SetUp()
            => statisticService = new StatisticService(context);

        [Test]
        public async Task TotalAsync_ShouldReturnCorrectOutput()
        {
            var result = await statisticService.TotalAsync();
            Assert.IsNotNull(result);

            var authorsCount = (await context.AllReadOnlyAsync<Author>()).Count();
            Assert.That(result.TotalAuthors, Is.EqualTo(authorsCount));

            var quizzesCount = (await context.AllReadOnlyAsync<Quiz>()).Count();
            Assert.That(result.TotalQuizzes, Is.EqualTo(quizzesCount));

            var triviasCount = (await context.AllReadOnlyAsync<Trivia>()).Count();
            Assert.That(result.TotalTrivias, Is.EqualTo(triviasCount));
        }
    }
}
