using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels.EngineType
{
    public class EngineTypeViewModel
    {
        public int Id { get; set; }
        public EngineEnum EngineType { get; set; }
        public bool IsChecked { get; set; }
    }
}
