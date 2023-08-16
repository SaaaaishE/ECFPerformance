using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.Services;
using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.Turbo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ECFPerformance.Constants.GeneralApplicationConstants;

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

        public async Task<IActionResult> Details(int id)
        {
            TurboViewModel viewModel = await turboService.GetTurboByIdAsync(id);

            return View(viewModel);
        }

        

        
    }
}
