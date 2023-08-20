using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ECFPerformance.Core.ViewModels;
using static ECFPerformance.Constants.ProductConstants;

namespace ECFPerformance.Core.FormModels.Turbo
{
    public class TurboFormModel
    {
        public TurboFormModel()
        {
            ScrollTypes = new HashSet<ScrollTypeViewModel>();
        }

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

        public int ScrollTypeId { get; set; }

        public IEnumerable<ScrollTypeViewModel> ScrollTypes { get; set; } = null!;
    }
}
