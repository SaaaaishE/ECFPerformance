using ECFPerformance.Core.FormModels.Turbo;
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

        public async Task EditTurboAsync(int turboId, TurboFormModel model)
        {
            Turbo currentTurbo = await dbContext.Turbos.FirstAsync(t => t.Id == turboId);
            currentTurbo.Name = model.Name;
            currentTurbo.Price = model.Price;
            currentTurbo.Quantity = model.Quantity;
            currentTurbo.Make = model.Make;
            currentTurbo.MainImage = model.MainImage;
            currentTurbo.ScrollTypeId = model.ScrollTypeId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ScrollTypeViewModel>> GetAllScrollTypesAsync()
        {
            return await dbContext.ScrollTypes
                .Select(x => new ScrollTypeViewModel()
                {
                    Id = x.Id,
                    ScrollType = x.ScrollType,
                })
                .ToArrayAsync();
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

        public async Task<TurboFormModel> GetTurboFormByIdAsync(int turboId)
        {
            Turbo currentTurbo = await dbContext.Turbos.FirstAsync(t => t.Id == turboId);

            IEnumerable<ScrollTypeViewModel> scrollTypes = await this.GetAllScrollTypesAsync();

            TurboFormModel model = new TurboFormModel()
            {
                MainImage = currentTurbo.MainImage,
                Make = currentTurbo.Make,
                Price = currentTurbo.Price,
                Quantity = currentTurbo.Quantity,
                Name = currentTurbo.Name,
                ScrollTypeId = currentTurbo.ScrollTypeId,
                ScrollTypes = scrollTypes
            };

            return model;
        }
    }
}
