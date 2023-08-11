using ECFPerformance.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Infrastructure.Data.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; } = null!;

    }
}
