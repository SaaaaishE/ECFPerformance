using ECFPerformance.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Contracts
{
    public interface ICarPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string MainImage { get; set; }
        public Category Category { get; set; }
    }
}
