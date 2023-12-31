﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ECFPerformance.Constants.OrderConstants;

namespace ECFPerformance.Infrastructure.Data.Models
{
    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
        }
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(DescrMaxLength)]
        public string Description { get; set; } = null!;

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalPrice { get; set; }
    }
}
