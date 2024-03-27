using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Statistic;
using QuizGame.Infrastructure.Repository;

namespace QuizGame.Core.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IRepository repository;

        public StatisticService(IRepository _repository)
        {
            repository = _repository;   
        } 

        public Task<StatisticModel> TotalAsync()
        {
            throw new NotImplementedException();
        }
    }
}
