using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class TurboShoppingCart
    {
        [ForeignKey(nameof(ShoppingCart))]
        public Guid ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; } = null!;

        [ForeignKey(nameof(Turbo))]
        public int TurboId { get; set; }
        public Turbo Turbo { get; set; } = null!;
    }
}
