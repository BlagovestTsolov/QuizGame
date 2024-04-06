using QuizGame.Core.Contracts;
using QuizGame.Core.Models.Statistic;
using QuizGame.Infrastructure.Data.Models;
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

        public async Task<StatisticModel> TotalAsync()
        {
            var quizzes = await repository.AllReadOnlyAsync<Quiz>();
            var authors = await repository.AllReadOnlyAsync<Author>();

            StatisticModel model = new()
            {
                TotalQuizzes = quizzes.Count,
                TotalAuthors = authors.Count
            };

            return model;
        }
    }
}
