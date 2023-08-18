using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels.ConnectingRod
{
    public class BeamTypeViewModel
    {
        public int Id { get; set; }
        public ConnectingRodBeamEnum BeamType { get; set; }
    }
}
