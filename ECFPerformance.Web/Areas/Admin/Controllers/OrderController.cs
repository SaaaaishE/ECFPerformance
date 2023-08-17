using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    public class OrderController : BaseAdminController
    {
        private IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet]
        public async Task<JsonResult> GetAllOrders()
        {
            IEnumerable<OrderViewModel> orders = await orderService.GetOrdersAsync();

            return new JsonResult(orders);
        }
    }
}
