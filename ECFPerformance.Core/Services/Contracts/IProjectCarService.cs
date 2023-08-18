using ECFPerformance.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services.Contracts
{
    public interface IProjectCarService
    {
        public Task<IEnumerable<AllProjectCarsViewModel>> GetAllProjectsAsync();
        public Task<ProjectCarViewModel> GetProjectCarAsync(int id);
    }
}
