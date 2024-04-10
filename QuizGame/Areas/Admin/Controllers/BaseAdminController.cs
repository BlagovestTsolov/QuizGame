using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static QuizGame.Core.Constants.AdminConstants;

namespace QuizGame.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRole)]
    public class BaseAdminController : Controller
    {
    }
}
