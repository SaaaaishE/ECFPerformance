using ECFPerformance.Core.FormModels.ConnectingRod;
using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Core.ViewModels.ConnectingRod;
using ECFPerformance.Core.ViewModels.EngineType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services.Contracts
{
    public interface IConnectingRodService
    {
        public Task<IEnumerable<AllConnectingRodsViewModel>> GetAllRodsAsync();
        public Task<ConnectingRodViewModel> GetRodByIdAsync(int rodId);
        public Task<IEnumerable<EngineTypeViewModel>> GetAllEngineTypesAsync();
        public Task<IEnumerable<BeamTypeViewModel>> GetAllBeamTypesAsync();
        public Task<ConnectingRodFormModel> GetRodFormByIdAsync(int rodId);
        public Task EditRodAsync(int rodId, ConnectingRodFormModel model);
        public Task<int> AddRodAsync(ConnectingRodFormModel model);
        public Task DeleteRodAsync(int rodId);
    }
}
