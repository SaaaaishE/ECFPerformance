using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class ProjectCarController : Controller
    {
        public async Task<IActionResult> ShowProjectCar(int id)
        {
            return View();
        }
    }
}
