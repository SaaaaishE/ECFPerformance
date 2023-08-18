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

        public Task EditRodAsync(int rodId, ConnectingRodFormModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BeamTypeViewModel>> GetAllBeamTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EngineTypeViewModel>> GetAllEngineTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllConnectingRodsViewModel>> GetAllRodsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ConnectingRodViewModel> GetRodByIdAsync(int rodId)
        {
            throw new NotImplementedException();
        }

        public Task<ConnectingRodFormModel> GetRodFormByIdAsync(int rodId)
        {
            throw new NotImplementedException();
        }
    }
}
