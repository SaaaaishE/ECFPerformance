using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        private IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<AllUsersViewModel>), 200)]
        public async Task<IActionResult> AllUsers()
        {
            IEnumerable<AllUsersViewModel> users = await userService.GetAllUsers();

            return this.Ok(users);
        }
    }
}
