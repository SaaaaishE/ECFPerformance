using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class EngineType
    {
        public EngineType()
        {
            ConnectingRods = new HashSet<ConnectingRodEngineType>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public EngineEnum EngineCode { get; set; }

        public ICollection<ConnectingRodEngineType> ConnectingRods { get; set; }
    }
}
