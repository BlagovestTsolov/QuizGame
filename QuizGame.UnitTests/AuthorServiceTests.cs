using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using QuizGame.UnitTests.Seed;

namespace QuizGame.UnitTests
{
    [TestFixture]
    public class AuthorServiceTests
    {
        private DbContextOptions<ApplicationDbContext> options;
        private ApplicationDbContext context;

        //[OneTimeSetUp]
        //public void OneTimeSetUp()
        //{
        //    options = new DbContextOptionsBuilder<ApplicationDbContext>()
        //        .UseInMemoryDatabase("InMemoryQuiz")
        //        .Options;

        //    context = new ApplicationDbContext(options);
        //}

        [Test]
        public void GetAuthorIdAsyncShouldReturnTheProperValue()
        {

        }
    }
}
