using Moq;
using QuizGame.Infrastructure.Data.Models;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.UnitTests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void RepositoryTest()
        {
            var mock = new Mock<IRepository>();

            mock.Setup(m => m.AddAsync(new Author())).Returns(() 
                => new Mock<IRepository>().Object);
        }
    }
}
