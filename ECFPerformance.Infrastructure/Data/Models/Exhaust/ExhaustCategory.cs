using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Exhaust
{
    public class ExhaustCategory : BaseCategory
    {
        public ExhaustCategory()
        {
            Manyfolds = new HashSet<ExhaustManyfold>();
            Silencers = new HashSet<ExhaustSilencer>();
        }

        public ICollection<ExhaustManyfold> Manyfolds { get; set; }
        public ICollection<ExhaustSilencer> Silencers { get; set;}
    }
}
