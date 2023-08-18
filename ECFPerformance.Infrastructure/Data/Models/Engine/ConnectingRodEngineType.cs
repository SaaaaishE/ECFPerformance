using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class ConnectingRodEngineType
    {
        [ForeignKey(nameof(EngineType))]
        public int EngineTypeId { get; set; }
        public EngineType EngineType { get; set; }

        [ForeignKey(nameof(ConnectingRod))]
        public int ConnectingRodId { get; set; }
        public ConnectingRod ConnectingRod { get; set; }
    }
}
