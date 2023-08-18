using ECFPerformance.Core.FormModels.ConnectingRod;
using ECFPerformance.Core.Services.Contracts;
using ECFPerformance.Core.ViewModels.ConnectingRod;
using ECFPerformance.Core.ViewModels.EngineType;
using ECFPerformance.Infrastructure.Data;
using ECFPerformance.Infrastructure.Data.Enums;
using ECFPerformance.Infrastructure.Data.Models.Engine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services
{
    public class ConnectingRodService : IConnectingRodService
    {
        private EcfDbContext dbContext;

        public ConnectingRodService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> AddRodAsync(ConnectingRodFormModel model)
        {
            HashSet<EngineType> engineTypes = new HashSet<EngineType>();

            foreach(EngineTypeViewModel viewModel in model.EngineTypes)
            {
                EngineType currentEngineType = await dbContext.EngineTypes
                    .FirstAsync(et => et.EngineCode == viewModel.EngineType);

                engineTypes.Add(currentEngineType);
            }

            ConnectingRod rod = new ConnectingRod()
            {
                Name = model.Name,
                MainImage = model.MainImage,
                Make = model.Make,
                Length = model.Length,
                PistonBoltDiameter = model.PistonBoltDiameter,
                Price = model.Price,
                Quantity = model.Quantity,
                BeamTypeId = model.BeamTypeId,
                CategoryId = 1,
                EngineTypes = engineTypes,
            };

            await dbContext.ConnectingRods.AddAsync(rod);
            await dbContext.SaveChangesAsync();

            return rod.Id;
        }

        public async Task DeleteRodAsync(int rodId)
        {
            ConnectingRod rod = await dbContext.ConnectingRods.FirstAsync(r => r.Id == rodId);

            dbContext.ConnectingRods.Remove(rod);

            await dbContext.SaveChangesAsync();
        }

        public async Task EditRodAsync(int rodId, ConnectingRodFormModel model)
        {
            HashSet<EngineType> engineTypes = new HashSet<EngineType>();

            foreach (EngineTypeViewModel viewModel in model.EngineTypes)
            {
                EngineType currentEngineType = await dbContext.EngineTypes
                    .FirstAsync(et => et.EngineCode == viewModel.EngineType);

                engineTypes.Add(currentEngineType);
            }

            ConnectingRod rod = await dbContext.ConnectingRods.FirstAsync(r => r.Id == rodId);

            rod.Name = model.Name;
            rod.Make = model.Make;
            rod.Length = model.Length;
            rod.Quantity = model.Quantity;
            rod.Price = model.Price;
            rod.PistonBoltDiameter = model.PistonBoltDiameter;
            rod.BeamTypeId = model.BeamTypeId;
            rod.EngineTypes = engineTypes;
            rod.MainImage = model.MainImage;

            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BeamTypeViewModel>> GetAllBeamTypesAsync()
        {
            return await dbContext.ConnectingRodBeamTypes
                .Select(b => new BeamTypeViewModel()
                {
                    Id = b.Id,
                    BeamType = b.ConnectingRodBeam,
                })
                .ToArrayAsync();
        }

        public async Task<IEnumerable<EngineTypeViewModel>> GetAllEngineTypesAsync()
        {
            return await dbContext.EngineTypes
                .Select(e => new EngineTypeViewModel()
                {
                    Id = e.Id,
                    EngineType = e.EngineCode,
                })
                .ToArrayAsync();
        }

        public async Task<IEnumerable<AllConnectingRodsViewModel>> GetAllRodsAsync()
        {
            return await dbContext.ConnectingRods
                .Select(c => new AllConnectingRodsViewModel()
                {
                    Id = c.Id,
                    MainImage = c.MainImage,
                    Name = c.Name,
                    Price = c.Price,
                    Quantity = c.Quantity,
                    BeamType = c.BeamType.ConnectingRodBeam
                })
                .ToArrayAsync();
        }

        public async Task<ConnectingRodViewModel> GetRodByIdAsync(int rodId)
        {
            ConnectingRod rod = await dbContext.ConnectingRods.FirstAsync(r => r.Id == rodId);

            return new ConnectingRodViewModel()
            {
                Id = rod.Id,
                Length = rod.Length,
                MainImage = rod.MainImage,
                Name = rod.Name,
                Make = rod.Make,
                Price = rod.Price,
                PistonBoltDiameter = rod.PistonBoltDiameter,
                Quantity = rod.Quantity,
            };
        }

        //todo
        public async Task<ConnectingRodFormModel> GetRodFormByIdAsync(int rodId)
        {
            ConnectingRod rod = await dbContext.ConnectingRods.FirstAsync(r => r.Id == rodId);

            return new ConnectingRodFormModel()
            {
                Length = rod.Length,
                Make = rod.Make,

            };
        }
    }
}
