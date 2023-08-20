using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.ShoppingCart;
using ECFPerformance.Core.ViewModels.Turbo;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Enums;
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

        public async Task AddProductToCartAsync(Guid userId, int productId, SubCategoryEnum subCategory)
        {
            ShoppingCart cart = await dbContext.ShoppingCarts
                .Include(t => t.Turbos)
                .Include(r => r.ConnectingRods)
                .FirstAsync(x => x.UserId == userId);

            if(subCategory == SubCategoryEnum.Turbo)
            {
                if (!cart.Turbos.Any(t => t.Id == productId))
                {
                    Turbo turbo = await dbContext.Turbos.FirstAsync(t => t.Id == productId);

                    cart.Turbos.Add(turbo);
                }
            }

            if(subCategory == SubCategoryEnum.ConnectingRod)
            {
                if (!cart.ConnectingRods.Any(r => r.Id == productId))
                {
                    ConnectingRod rod = await dbContext.ConnectingRods.FirstAsync(r => r.Id == productId);

                    cart.ConnectingRods.Add(rod);
                }
            }
                   
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
                .Include(t => t.Turbos)
                .Include(c => c.ConnectingRods)
                .FirstAsync(x => x.UserId == userId);

            HashSet<ProductInCartViewModel> productsInCart = new HashSet<ProductInCartViewModel>();

            foreach(Turbo turbo in currentCart.Turbos)
            {
                productsInCart.Add(new ProductInCartViewModel()
                {
                    Id = turbo.Id,
                    Name = turbo.Name,
                    SubCategory = SubCategoryEnum.Turbo,
                    Price = turbo.Price,
                });
            }

            foreach(ConnectingRod rod in currentCart.ConnectingRods)
            {
                productsInCart.Add(new ProductInCartViewModel()
                {
                    Id= rod.Id,
                    Name = rod.Name,
                    Price= rod.Price,
                    SubCategory = SubCategoryEnum.ConnectingRod
                });
            }

            ShoppingCartViewModel model = new ShoppingCartViewModel()
            {
                ProductsInCart = productsInCart,
            };

            return model;
        }

        public async Task RemoveProductFromCartAsync(Guid userId, int productId, SubCategoryEnum subCategory)
        {
            ShoppingCart cart = await dbContext.ShoppingCarts
                .Include (t => t.Turbos)
                .Include (r => r.ConnectingRods)
                .FirstAsync(x => x.UserId == userId);

            if(subCategory == SubCategoryEnum.Turbo)
            {
                Turbo? turbo = cart.Turbos.FirstOrDefault(t => t.Id == productId);

                if (turbo != null)
                {
                    cart.Turbos.Remove(turbo);

                    await dbContext.SaveChangesAsync();
                }
            }
            else if(subCategory == SubCategoryEnum.ConnectingRod)
            {
                ConnectingRod? rod = cart.ConnectingRods.FirstOrDefault(r => r.Id == productId);

                if (rod != null)
                {
                    cart.ConnectingRods.Remove(rod);

                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
