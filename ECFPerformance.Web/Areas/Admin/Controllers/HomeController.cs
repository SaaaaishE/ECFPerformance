using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
