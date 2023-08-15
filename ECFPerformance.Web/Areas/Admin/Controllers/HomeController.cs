using ECFPerformance.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        private IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
