using ECFPerformance.Infrastructure.Contracts;
using ECFPerformance.Infrastructure.Data.Models.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string MainImage { get; set; } = null!;

        public ICollection<Turbo> Turbos { get; set; }

        public ICollection<ConnectingRod> ConnectingRods { get; set;}
    }
}
