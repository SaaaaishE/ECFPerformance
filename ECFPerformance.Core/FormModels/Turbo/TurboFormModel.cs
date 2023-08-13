using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECFPerformance.Core.ViewModels;

namespace ECFPerformance.Core.FormModels.Turbo
{
    public class TurboFormModel
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

        public int ScrollTypeId { get; set; }

        public IEnumerable<ScrollTypeViewModel> ScrollTypes { get; set; } = null!;
    }
}
