using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.Services;
using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
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

        [HttpGet]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Edit(int id)
        {
            TurboFormModel formModel = await turboService.GetTurboFormByIdAsync(id);

            return View(formModel);
        }

        [HttpPost]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Edit(int id, TurboFormModel formModel)
        {
            await turboService.EditTurboAsync(id, formModel);

            return RedirectToAction("Details", new { id });
        }

        [HttpGet]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Add()
        {
            TurboFormModel formModel = new TurboFormModel();
            formModel.ScrollTypes = await turboService.GetAllScrollTypesAsync();

            return View(formModel);
        }

        [HttpPost]
        [Authorize(Roles = AdminRoleName)]
        public async Task<IActionResult> Add(TurboFormModel formModel)
        {
            int id = await turboService.AddTurboAsync(formModel);

            return RedirectToAction("Details", new { id });
        }
    }
}
