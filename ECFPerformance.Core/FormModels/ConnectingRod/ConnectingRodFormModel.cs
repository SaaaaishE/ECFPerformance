using ECFPerformance.Core.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECFPerformance.Core.ViewModels.EngineType;
using ECFPerformance.Core.ViewModels.ConnectingRod;

namespace ECFPerformance.Core.FormModels.ConnectingRod
{
    public class ConnectingRodFormModel
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Make { get; set; } = null!;

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [Required]
        public string MainImage { get; set; } = null!;

        public int Length { get; set; }

        public int PistonBoltDiameter { get; set; }

        public int BeamTypeId { get; set; }

        public IEnumerable<EngineTypeViewModel> EngineTypes { get; set; } = null!;
        public IEnumerable<BeamTypeViewModel> BeamTypes { get; set; } = null!;
    }
}
