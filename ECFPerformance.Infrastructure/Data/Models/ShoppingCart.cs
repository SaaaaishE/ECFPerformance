using ECFPerformance.Infrastructure.Data.Models.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Turbos = new HashSet<Turbo>();
            ConnectingRods = new HashSet<ConnectingRod>();
        }
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Turbo> Turbos { get; set; }

        public ICollection<ConnectingRod> ConnectingRods { get; set; }
    }
}
