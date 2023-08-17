using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task<IActionResult> PlaceOrder()
        {
            Guid userId = Guid.Parse(User.GetId());
            await orderService.PlaceOrder(userId);

            return View();
        }
    }
}
