using ECFPerformance.Core.FormModels.ConnectingRod;
using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.ConnectingRod;
using ECFPerformance.Core.ViewModels.Turbo;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class ConnectingRodController : BaseAdminController
    {
        private IConnectingRodService connectingRodService;

        public ConnectingRodController(IConnectingRodService connectingRodService)
        {
            this.connectingRodService = connectingRodService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ConnectingRodFormModel formModel = new ConnectingRodFormModel();
            formModel.EngineTypes = await connectingRodService.GetAllEngineTypesAsync();
            formModel.BeamTypes = await connectingRodService.GetAllBeamTypesAsync();

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConnectingRodFormModel formModel)
        {
            if (!ModelState.IsValid)
                return View(formModel);

            int id = await connectingRodService.AddRodAsync(formModel);

            return RedirectToAction("Details", "ConnectingRod", new { area = "", id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ConnectingRodFormModel formModel = await connectingRodService.GetRodFormByIdAsync(id);

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ConnectingRodFormModel formModel)
        {
            if (!ModelState.IsValid)
                return View(formModel);

            await connectingRodService.EditRodAsync(id, formModel);

            return RedirectToAction("Details", "ConnectingRod", new { area = "", id });
        }

        public async Task<IActionResult> DeleteView(int id)
        {
            ConnectingRodViewModel model = await connectingRodService.GetRodByIdAsync(id);

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await connectingRodService.DeleteRodAsync(id);

            return RedirectToAction("ConnectingRods", "ConnectingRod", new { area = "" });
        }
    }
}
