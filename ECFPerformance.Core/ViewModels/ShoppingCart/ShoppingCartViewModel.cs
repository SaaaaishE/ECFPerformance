﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels.ShoppingCart
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<ProductInCartViewModel> ProductsInCart { get; set; }
    }
}
