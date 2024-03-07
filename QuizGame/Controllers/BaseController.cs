using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QuizGame.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
