using QuizGame.Core.Models.Statistic;

namespace QuizGame.Core.Contracts
{
    public interface IStatisticService
    {
        Task<StatisticModel> TotalAsync();
    }
}
