using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private IShoppingCartService cartService;

        public ShoppingCartController(IShoppingCartService cartService)
        {
            this.cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            //ShoppingCartViewModel viewModel = cartService.GetShoppingCartByUserIdAsync();

            return View();
        }
    }
}
