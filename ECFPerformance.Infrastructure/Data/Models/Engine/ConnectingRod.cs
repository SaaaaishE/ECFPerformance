using ECFPerformance.Infrastructure.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECFPerformance.Infrastructure.Data.Models.Projects;
using static ECFPerformance.Constants.ProductConstants;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class ConnectingRod : ICarPart
    {
        public ConnectingRod()
        {
            EngineTypes = new HashSet<EngineType>();
            ProjectCars = new HashSet<ProjectCar>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MakeMaxLength)]
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

        public ICollection<ShoppingCart> ShoppingCarts { get; set;}
    }
}
