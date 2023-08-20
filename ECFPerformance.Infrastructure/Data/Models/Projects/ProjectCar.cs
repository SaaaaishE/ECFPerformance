using ECFPerformance.Infrastructure.Data.Models.Engine;
using System.ComponentModel.DataAnnotations;
using static ECFPerformance.Constants.ProjectCarConstants;

namespace ECFPerformance.Infrastructure.Data.Models.Projects
{
    public class ProjectCar
    {
        public ProjectCar()
        {
            Turbos = new HashSet<Turbo>();
            ConnectingRods = new HashSet<ConnectingRod>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescrMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string MainImage { get; set; } = null!;

        public ICollection<Turbo> Turbos { get; set; }

        public ICollection<ConnectingRod> ConnectingRods { get; set;}
    }
}
