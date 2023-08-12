using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ECFPerformance.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public async Task<IActionResult> Index()
        {
            HashSet<AllProjectCarsViewModel> projects = new HashSet<AllProjectCarsViewModel>()
            {
                new AllProjectCarsViewModel()
                {
                    Id = 1,
                    Name = "Valkata",
                    MainImage = "/imgs/valkata.jpg"
                },
                new AllProjectCarsViewModel()
                {
                    Id = 2,
                    Name = "Valkata",
                    MainImage = "https://th.bing.com/th/id/OIP.WXZ44MYGOyypnUxAONa9GAHaE8?w=274&h=183&c=7&r=0&o=5&pid=1.7"
                },
                new AllProjectCarsViewModel()
                {
                    Id = 3,
                    Name = "Valkata",
                    MainImage = "https://th.bing.com/th/id/OIP.WXZ44MYGOyypnUxAONa9GAHaE8?w=274&h=183&c=7&r=0&o=5&pid=1.7"
                },
                new AllProjectCarsViewModel()
                {
                    Id = 4,
                    Name = "Valkata",
                    MainImage = "https://th.bing.com/th/id/OIP.WXZ44MYGOyypnUxAONa9GAHaE8?w=274&h=183&c=7&r=0&o=5&pid=1.7"
                },
                new AllProjectCarsViewModel()
                {
                    Id = 5,
                    Name = "Valkata",
                    MainImage = "https://th.bing.com/th/id/OIP.WXZ44MYGOyypnUxAONa9GAHaE8?w=274&h=183&c=7&r=0&o=5&pid=1.7"
                }
            };

            return View(projects);
        }
    }
}