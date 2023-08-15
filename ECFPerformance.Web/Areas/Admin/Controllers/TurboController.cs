using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.Services;
using static ECFPerformance.Constants.GeneralApplicationConstants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using ECFPerformance.Core.Services.Contracts;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class TurboController : BaseAdminController
    {
        private ITurboService turboService;

        public TurboController(ITurboService turboService)
        {
            this.turboService = turboService;
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

            return RedirectToAction("Details", "Turbo", new { area = "", id });
        }
    }
}
