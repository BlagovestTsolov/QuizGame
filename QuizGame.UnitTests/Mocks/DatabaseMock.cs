using Microsoft.EntityFrameworkCore;
using QuizGame.Data;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.UnitTests.Mocks
{
    public static class DatabaseMock
    {
        public static IRepository Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("QuizDbMock")
                    .Options;

                return new Repository
                    (new ApplicationDbContext(dbContextOptions, false));
            }
        }
    }
}
