using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class EngineController : Controller
    {
        public async Task<IActionResult> Index()
        {

            return View();
        }

        public async Task<IActionResult> ConnectingRods()
        {
            return View();
        }
    }
}
