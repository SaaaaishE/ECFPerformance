using ECFPerformance.Core.ViewModels;
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
        public Task AddTurboToCartAsync(Guid userId, int turboId);
        public Task RemoveTurboFromCartAsync(Guid userId, int turboId);
    }
}
