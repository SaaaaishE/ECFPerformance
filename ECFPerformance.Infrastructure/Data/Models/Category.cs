using ECFPerformance.Infrastructure.Data.Models.Engine;
using System.ComponentModel.DataAnnotations;
using static ECFPerformance.Constants.Category;

namespace ECFPerformance.Infrastructure.Data.Models
{
    public class Category
    {
        public Category()
        {
            Turbos = new HashSet<Turbo>();
            ConnectingRods = new HashSet<ConnectingRod>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; } = null!;

        public ICollection<Turbo> Turbos { get; set; }

        public ICollection<ConnectingRod> ConnectingRods { get; set; }
    }
}
