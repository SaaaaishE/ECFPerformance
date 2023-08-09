using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class EngineCategory : BaseCategory
    {
        public EngineCategory()
        {
            Turbos = new HashSet<Turbo>();
            ConnectingRods = new HashSet<ConnectingRod>();
        }

        public ICollection<Turbo> Turbos { get; set; }

        public ICollection<ConnectingRod> ConnectingRods { get; set; }
    }
}
