using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Models;
using ECFPerformance.Infrastructure.Data.Models.Engine;
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

        public async Task<IEnumerable<OrderViewModel>> GetOrdersAsync()
        {
            return await dbContext.Orders
                .Include(u => u.User)
                .OrderByDescending(o => o.CreatedOn)
                .Select(o => new OrderViewModel()
                {
                    Id = o.Id,
                    Description = o.Description,
                    TotalPrice = o.TotalPrice,
                    UserId = o.UserId,
                    UserEmail = o.User.Email,
                    UserPhone = o.User.PhoneNumber,
                    CreatedOn = o.CreatedOn,
                })
                .ToArrayAsync();
        }

        public async Task PlaceOrderAsync(Guid userId)
        {
            StringBuilder orderDescr = new StringBuilder();
            ShoppingCart currentCart = await dbContext.ShoppingCarts
                .Include(t => t.Turbos)
                .Include(r => r.ConnectingRods)
                .FirstAsync(c => c.UserId == userId);

            decimal totalPrice = 0;

            if(currentCart.Turbos != null && currentCart.Turbos.Count > 0)
            {
                orderDescr.Append("Turbos: ");
                foreach(var turbo in currentCart.Turbos)
                {
                    orderDescr.AppendLine($" {turbo.Name}");
                    orderDescr.AppendLine($" - $ {turbo.Price}\n");
                    totalPrice += turbo.Price;
                }
            }

            if(currentCart.ConnectingRods != null && currentCart.ConnectingRods.Count > 0)
            {
                orderDescr.AppendLine("Connecting Rods: ");
                foreach(var rod in currentCart.ConnectingRods)
                {
                    orderDescr.AppendLine($" {rod.Name}");
                    orderDescr.AppendLine($" - $ {rod.Price}\n");
                    totalPrice += rod.Price;
                }
            }

            Order order = new Order()
            {
                UserId = userId,
                Description = orderDescr.ToString(),
                TotalPrice = totalPrice,
            };

            currentCart.Turbos.Clear();
            currentCart.ConnectingRods.Clear();

            await dbContext.Orders.AddAsync(order);
            await dbContext.SaveChangesAsync();
        }
    }
}
