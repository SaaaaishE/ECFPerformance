using ECFPerformance.Infrastructure.Contracts;
using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECFPerformance.Infrastructure.Data.Models.Projects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class ConnectingRod : ICarPart
    {
        public ConnectingRod()
        {
            EngineTypes = new HashSet<EngineType>();
            ProjectCars = new HashSet<ProjectCar>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Make { get; set; } = null!;

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string MainImage { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<ProjectCar> ProjectCars { get; set; }

        public int Length { get; set; }

        public int PistonBoltDiameter { get; set; }

        [ForeignKey(nameof(BeamType))]
        public int BeamTypeId { get; set; }
        [Required]
        public ConnectingRodBeamType BeamType { get; set; } = null!;

        public ICollection<EngineType> EngineTypes { get; set; }
    }
}
