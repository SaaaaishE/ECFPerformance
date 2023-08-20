using ECFPerformance.Core.ViewModels.ShoppingCart;
using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services.Contracts
{
    public interface IShoppingCartService
    {
        public Task CreateCartAsync(Guid userId);
        public Task<ShoppingCartViewModel> GetShoppingCartByUserIdAsync(Guid userId);
        public Task AddProductToCartAsync(Guid userId, int turboId, SubCategoryEnum subCategory);
        public Task RemoveProductFromCartAsync(Guid userId, int turboId, SubCategoryEnum subCategory);
    }
}
