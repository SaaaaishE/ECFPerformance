using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECFPerformance.Core.ViewModels.EngineType;
using ECFPerformance.Core.ViewModels.ConnectingRod;
using static ECFPerformance.Constants.ProductConstants;

namespace ECFPerformance.Core.FormModels.ConnectingRod
{
    public class ConnectingRodFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(MakeMaxLength, MinimumLength = MakeMinLength)]
        public string Make { get; set; } = null!;

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [Required]
        public string MainImage { get; set; } = null!;

        public int Length { get; set; }

        public int PistonBoltDiameter { get; set; }

        public int BeamTypeId { get; set; }

        public IEnumerable<int> EngineTypeIds { get; set; } = null!;

        public IEnumerable<EngineTypeViewModel> EngineTypes { get; set; } = null!;
        public IEnumerable<BeamTypeViewModel> BeamTypes { get; set; } = null!;
    }
}
