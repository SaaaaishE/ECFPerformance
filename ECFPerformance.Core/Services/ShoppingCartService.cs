﻿using ECFPerformance.Core.Services.Contracts;
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
    public class ShoppingCartService : IShoppingCartService
    {
        private EcfDbContext dbContext;

        public ShoppingCartService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddTurboToCartAsync(Guid userId, int turboId)
        {
            ShoppingCart cart = await dbContext.ShoppingCarts.FirstAsync(x => x.UserId == userId);

            TurboShoppingCart turboShoppingCart = new TurboShoppingCart()
            {
                TurboId = turboId,
                ShoppingCartId = cart.Id
            };

            await dbContext.TurbosShoppingCarts.AddAsync(turboShoppingCart);
            await dbContext.SaveChangesAsync();
        }

        public async Task CreateCartAsync(Guid userId)
        {
            bool cartExists = await dbContext.ShoppingCarts.AnyAsync(x => x.UserId == userId);

            if (!cartExists)
            {
                ShoppingCart cart = new ShoppingCart()
                {
                    UserId = userId,
                };

                await dbContext.ShoppingCarts.AddAsync(cart);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<ShoppingCartViewModel> GetShoppingCartByUserIdAsync(Guid userId)
        {
            ShoppingCart currentCart = await dbContext.ShoppingCarts
                .Include(t => t.TurbosInCart)
                .FirstAsync(x => x.UserId == userId);

            ShoppingCartViewModel model = new ShoppingCartViewModel()
            {
                TurbosInCart = currentCart.TurbosInCart
                                    .Select(x => new TurboInCartViewModel()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Price = x.Price,
                                        Quantity = x.Quantity,
                                    })
            };

            return model;
        }
    }
}