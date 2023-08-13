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
        [ForeignKey(nameof(CompatibleEngine))]
        public int CompatibleEngineId { get; set; }
        public EngineType CompatibleEngine { get; set; }

        [ForeignKey(nameof(CompatibleRod))]
        public int CompatibleRodId { get; set; }
        public ConnectingRod CompatibleRod { get; set; }
    }
}
