using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class EngineController : Controller
    {
        private ICategoryService categoryService;

        public EngineController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryNamesViewModel> categories = await categoryService.GetCategoriesNamesAsync();

            return View(categories);
        }

        public async Task<IActionResult> Turbos()
        {
            IEnumerable<CategoryNamesViewModel> categories = await categoryService.GetCategoriesNamesAsync();
            return View(categories);
        }

        public async Task<IActionResult> ConnectingRods()
        {
            IEnumerable<CategoryNamesViewModel> categories = await categoryService.GetCategoriesNamesAsync();
            return View(categories);
        }
    }
}
