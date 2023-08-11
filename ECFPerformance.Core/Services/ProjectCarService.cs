using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services
{
    public class ProjectCarService : IProjectCarService
    {
        private EcfDbContext dbContext;

        public ProjectCarService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllProjectCarsViewModel>> GetAllProjectsAsync()
        {
            return await dbContext.ProjectCars
                .Select(x => new AllProjectCarsViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    MainImage = x.MainImage,
                })
                .ToArrayAsync();
        }
    }
}
