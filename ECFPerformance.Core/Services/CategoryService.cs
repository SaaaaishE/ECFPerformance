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
    public class CategoryService : ICategoryService
    {
        private EcfDbContext dbContext;

        public CategoryService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<CategoryNamesViewModel>> GetCategoriesNamesAsync()
        {
            return await dbContext.Categories
                .Select(x => new CategoryNamesViewModel()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                })
                .ToArrayAsync();
        }
    }
}
