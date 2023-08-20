using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.ShoppingCart;
using ECFPerformance.Infrastructure.Data.Enums;
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
        [Route("ShoppingCart/AddProduct/{id}/{subCategory}")]
        public async Task<JsonResult> AddProductToCart(int id, string subCategory)
        {
            Guid userId = Guid.Parse(User.GetId());

            SubCategoryEnum subCategoryEnum = (SubCategoryEnum)Enum.Parse(typeof(SubCategoryEnum), subCategory);

            await cartService.CreateCartAsync(userId);

            await cartService.AddProductToCartAsync(userId, id, subCategoryEnum);

            return new JsonResult(201);
        }

        [HttpGet]
        [Route("ShoppingCart/RemoveProduct/{id}/{subCategory}")]
        public async Task<IActionResult> RemoveProductFromCart(int id, string subCategory)
        {
            Guid userId = Guid.Parse(User.GetId());

            SubCategoryEnum subCategoryEnum = (SubCategoryEnum)Enum.Parse(typeof(SubCategoryEnum), subCategory);

            await cartService.RemoveProductFromCartAsync(userId, id, subCategoryEnum);

            return RedirectToAction("Index");
        }
    }
}
