using ECFPerformance.Core.ViewModels.EngineType;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECFPerformance.Infrastructure.Data.Enums;

namespace ECFPerformance.Core.ViewModels.ConnectingRod
{
    public class ConnectingRodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
      
        public string Make { get; set; } = null!;

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string MainImage { get; set; } = null!;

        public int Length { get; set; }

        public int PistonBoltDiameter { get; set; }

        public SubCategoryEnum SubCategory { get; set; }

        public ConnectingRodBeamEnum BeamType { get; set; }

        public IEnumerable<EngineTypeViewModel> EngineTypes { get; set; } = null!;
        public IEnumerable<BeamTypeViewModel> BeamTypes { get; set; } = null!;
    }
}
