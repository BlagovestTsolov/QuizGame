using Microsoft.AspNetCore.Identity;
using QuizGame.Core.Contracts;
using QuizGame.Core.Services;

namespace QuizGame.UnitTests.UnitTests
{
    [TestFixture]
    public class UserServiceTests : UnitTestsBase
    {
        private IUserService userService;

        [OneTimeSetUp]
        public void SetUp()
            => userService = new UserService(context);

        [Test]
        public async Task GetAllUsersAsync_ShouldReturnCorrectData()
        {
            var result = (await userService.GetAllUsersAsync()).Count();
            var usersCount = (await context.AllReadOnlyAsync<IdentityUser>()).Count();

            Assert.That(result, Is.EqualTo(usersCount));
        }
    }
}
