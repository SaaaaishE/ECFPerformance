using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Models.Projects;
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
                    Description = x.Description
                })
                .ToArrayAsync();
        }

        public async Task<ProjectCarViewModel> GetProjectCarAsync(int id)
        {
            ProjectCar projectCar = await dbContext.ProjectCars.FirstAsync(x => x.Id == id);

            return new ProjectCarViewModel()
            {
                Id = projectCar.Id,
                Name = projectCar.Name,
                MainImage = projectCar.MainImage,
                Description = projectCar.Description
            };
        }
    }
}
