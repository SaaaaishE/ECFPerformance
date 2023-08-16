using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    //[Authorize]
    public class ShoppingCartController : Controller
    {
        private IShoppingCartService cartService;

        public ShoppingCartController(IShoppingCartService cartService)
        {
            this.cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            Guid userId = Guid.Parse(User.GetId());

            await cartService.CreateCartAsync(userId);

            ShoppingCartViewModel viewModel = await cartService.GetShoppingCartByUserIdAsync(userId);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> AddTurboToCart(int id)
        {
            Guid userId = Guid.Parse(User.GetId());

            await cartService.CreateCartAsync(userId);

            await cartService.AddTurboToCartAsync(userId, id);

            return new JsonResult(201);
        }

        [HttpGet]
        public async Task<IActionResult> RemoveTurboFromCart(int id)
        {
            Guid userId = Guid.Parse(User.GetId());

            await cartService.RemoveTurboFromCartAsync(userId, id);

            return RedirectToAction("Index");
        }
    }
}
