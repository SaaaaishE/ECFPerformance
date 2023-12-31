﻿using ECFPerformance.Infrastructure.Contracts;
using ECFPerformance.Infrastructure.Data.Models.Projects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ECFPerformance.Constants.ProductConstants;

namespace ECFPerformance.Infrastructure.Data.Models.Engine
{
    public class Turbo : ICarPart
    {
        public Turbo()
        {
            ProjectCars = new HashSet<ProjectCar>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

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

        [ForeignKey(nameof(ScrollType))]
        public int ScrollTypeId { get; set; }
        public TurboScrollType ScrollType { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<ProjectCar> ProjectCars { get; set; }

        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
