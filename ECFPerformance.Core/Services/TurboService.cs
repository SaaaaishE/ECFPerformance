using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Models.Engine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ECFPerformance.Core.Services
{
    public class TurboService : ITurboService
    {
        private EcfDbContext dbContext;

        public TurboService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;    
        }

        public async Task<IEnumerable<AllTurbosViewModel>> GetAllTurbosAsync()
        {
            return await dbContext.Turbos
                .Include(t => t.ScrollType)
                .Select(t => new AllTurbosViewModel
                {
                    Id = t.Id,
                    MainImage = t.MainImage,
                    Name = t.Name,
                    Price = t.Price,
                    Quantity = t.Quantity,
                    ScrollType = t.ScrollType,
                })
                .ToArrayAsync();
        }

        public async Task<TurboViewModel> GetTurboByIdAsync(int turboId)
        {
            var turbo = await dbContext.Turbos
                .Include(t => t.ScrollType)
                .FirstAsync(x => x.Id == turboId);

            TurboViewModel turboViewModel = new TurboViewModel()
            {
                Id = turbo.Id,
                Name = turbo.Name,
                Make = turbo.Make,
                Price = turbo.Price,
                Quantity = turbo.Quantity,
                ScrollType = turbo.ScrollType,
                MainImage = turbo.MainImage
            };

            return turboViewModel;
        }
    }
}
