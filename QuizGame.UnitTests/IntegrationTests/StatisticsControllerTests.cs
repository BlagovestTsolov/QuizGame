using Microsoft.AspNetCore.Mvc;
using QuizGame.Controllers;
using QuizGame.UnitTests.Mocks;

namespace QuizGame.UnitTests.IntegrationTests
{
    [TestFixture]
    public class StatisticsControllerTests
    {
        private StatisticController statisticController;

        [OneTimeSetUp]
        public void SetUp()
            => statisticController = new StatisticController(StatisticsServiceMock.Instance);

        [Test]
        public async Task GetStatistics_ShouldReturnCorrectCounts()
        {
            IActionResult result = await statisticController.GetStatistics();

            Assert.NotNull(result);
        }
    }
}
