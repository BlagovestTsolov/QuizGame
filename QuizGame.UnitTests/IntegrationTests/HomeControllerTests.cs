using Microsoft.AspNetCore.Mvc;
using QuizGame.Controllers;

namespace QuizGame.UnitTests.IntegrationTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController homeController;

        [OneTimeSetUp]
        public void SetUp()
            => homeController = new HomeController(null);

        [Test]
        public void Error_ShouldReturnCorrectView()
        {
            var statusCode = 500;

            var result = homeController.Error(statusCode);

            Assert.IsNotNull(result);

            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);
        }
    }
}
