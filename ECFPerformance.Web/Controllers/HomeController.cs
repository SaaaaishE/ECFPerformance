using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECFPerformance.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProjectCarService projectCarService;

        public HomeController(IProjectCarService projectCarService)
        {
            this.projectCarService = projectCarService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<AllProjectCarsViewModel> projects = await projectCarService.GetAllProjectsAsync();

            return View(projects);
        }
    }
}