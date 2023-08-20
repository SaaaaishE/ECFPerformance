using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
