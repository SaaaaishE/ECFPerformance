using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECFPerformance.Infrastructure.Data.Enums;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class ConnectingRodBeamType
    {
        public ConnectingRodBeamType()
        {
            ConnectingRods = new HashSet<ConnectingRod>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public ConnectingRodBeamEnum ConnectingRodBeam { get; set;}

        public ICollection<ConnectingRod> ConnectingRods { get; set;}
    }
}
