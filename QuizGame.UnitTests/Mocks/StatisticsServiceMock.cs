using Moq;
using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Statistic;

namespace QuizGame.UnitTests.Mocks
{
    public class StatisticsServiceMock
    {
        public static IStatisticService Instance
        {
            get
            {
                var statisticsServiceMock = new Mock<IStatisticService>();

                statisticsServiceMock
                   .Setup(s => s.TotalAsync())
                   .Returns(async () => new StatisticModel()
                   {
                       TotalAuthors = 1,
                       TotalQuizzes = 3,
                       TotalTrivias = 3
                   });

                return statisticsServiceMock.Object;
            }
        }
    }
}
