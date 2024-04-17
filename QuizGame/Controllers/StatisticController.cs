using Microsoft.AspNetCore.Mvc;
using QuizGame.Core.Contracts;

namespace QuizGame.Controllers
{
    public class StatisticController : BaseController
    {
        private readonly IStatisticService statisticService;

        public StatisticController(IStatisticService _statisticService)
        {
            statisticService = _statisticService;
        }

        public async Task<IActionResult> GetStatistics()
            => View(await statisticService.TotalAsync());
    }
}
