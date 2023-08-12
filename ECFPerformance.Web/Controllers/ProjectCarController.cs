using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class ProjectCarController : Controller
    {
        public async Task<IActionResult> ShowProjectCar(int id)
        {
            ProjectCarViewModel projectCarViewModel = new ProjectCarViewModel()
            {
                Id = id,
                Description = "Na valkata kolata",
                Name = "Valkata",
                MainImage = "/imgs/valkata.jpg"
            };

            return View(projectCarViewModel);
        }
    }
}
