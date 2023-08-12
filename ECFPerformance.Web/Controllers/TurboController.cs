using ECFPerformance.Core.Services;
using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class TurboController : Controller
    {
        private ITurboService turboService;

        public TurboController(ITurboService turboService)
        {
            this.turboService = turboService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Turbos()
        {
            IEnumerable<AllTurbosViewModel> turbos = await turboService.GetAllTurbosAsync();

            return View(turbos);
        }
    }
}
