using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels
{
    public class AllProductsViewModel
    {
        public int Id { get; set; }
        public SubCategoryEnum SubCategory { get; set; }
        public string Name { get; set; } = null!;
        public string MainImage { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
