using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class TurboScrollType
    {
        public TurboScrollType()
        {
            Turbos = new HashSet<Turbo>();
        }

        [Key]
        public int Id { get; set; }

        public ScrollType ScrollType { get; set; }

        public ICollection<Turbo> Turbos { get; set; }
    }
}
