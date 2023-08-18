using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class ProjectCarController : Controller
    {
        private IProjectCarService projectCarService;

        public ProjectCarController(IProjectCarService projectCarService)
        {
            this.projectCarService = projectCarService;
        }
        public async Task<IActionResult> ShowProjectCar(int id)
        {
            ProjectCarViewModel projectCarViewModel = await projectCarService.GetProjectCarAsync(id);

            return View(projectCarViewModel);
        }
    }
}
