using ECFPerformance.Infrastructure.Contracts;
using ECFPerformance.Infrastructure.Data.Models.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class Turbo : ICarPart
    {
        public Turbo()
        {
            ProjectCars = new HashSet<ProjectCar>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Make { get; set; } = null!;

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(ScrollType))]
        public int ScrollTypeId { get; set; }
        public TurboScrollType ScrollType { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<ProjectCar> ProjectCars { get; set; }
    }
}
