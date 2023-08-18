using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.ConnectingRod;
using ECFPerformance.Core.ViewModels.Turbo;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class ConnectingRodController : Controller
    {
        private IConnectingRodService connectingRodService;

        public ConnectingRodController(IConnectingRodService connectingRodService)
        {
            this.connectingRodService = connectingRodService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ConnectingRods()
        {
            IEnumerable<AllConnectingRodsViewModel> rods = await connectingRodService.GetAllRodsAsync();

            return View(rods);
        }

        public async Task<IActionResult> Details(int id)
        {
            ConnectingRodViewModel viewModel = await connectingRodService.GetRodByIdAsync(id);

            return View(viewModel);
        }
    }
}
