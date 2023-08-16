using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<TurboInCartViewModel> TurbosInCart { get; set; }
    }
}
