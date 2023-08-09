using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class ConnectingRod
    {
        public ConnectingRod()
        {
            CompatibleEngines = new HashSet<EngineEnum>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; } = null!;

        public int Length { get; set; }

        public int PistonBoltDiameter { get; set; }

        [Required]
        public ConnectingRodBeamEnum BeamType { get; set; }

        [ForeignKey(nameof(EngineCategory))]
        public int EngineCategoryId { get; set; }
        public EngineCategory EngineCategory { get; set; } = null!;

        public ICollection<EngineEnum> CompatibleEngines { get; set; }
    }
}
