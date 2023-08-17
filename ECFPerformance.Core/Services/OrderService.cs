using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services
{
    public class OrderService : IOrderService
    {
        private EcfDbContext dbContext;

        public OrderService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task PlaceOrder(Guid userId)
        {
            StringBuilder orderDescr = new StringBuilder();
            ShoppingCart currentCart = await dbContext.ShoppingCarts
                .Include(t => t.Turbos)
                .FirstAsync(c => c.UserId == userId);

            decimal totalPrice = 0;

            if(currentCart.Turbos != null && currentCart.Turbos.Count > 0)
            {
                orderDescr.Append("Turbos:");
                foreach(var turbo in currentCart.Turbos)
                {
                    orderDescr.AppendLine($" {turbo.Name}");
                    orderDescr.AppendLine($" - $ {turbo.Price}\n");
                    totalPrice += turbo.Price;
                }
            }

            Order order = new Order()
            {
                UserId = userId,
                Description = orderDescr.ToString(),
                TotalPrice = totalPrice,
            };

            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
        }
    }
}
