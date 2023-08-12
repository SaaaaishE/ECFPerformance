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
        public string Name { get; set; } = null!;
        public string MainImage { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
