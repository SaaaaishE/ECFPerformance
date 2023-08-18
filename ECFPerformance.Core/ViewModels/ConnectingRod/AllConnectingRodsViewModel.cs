using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels.ConnectingRod
{
    public class AllConnectingRodsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string MainImage { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ConnectingRodBeamEnum BeamType { get; set; }
    }
}
