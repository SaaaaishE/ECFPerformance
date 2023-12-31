﻿using ECFPerformance.Core.FormModels.Turbo;
using ECFPerformance.Core.ViewModels;
using ECFPerformance.Core.ViewModels.Turbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services.Contracts
{
    public interface ITurboService
    {
        public Task<IEnumerable<AllTurbosViewModel>> GetAllTurbosAsync();
        public Task<TurboViewModel> GetTurboByIdAsync(int turboId);
        public Task<IEnumerable<ScrollTypeViewModel>> GetAllScrollTypesAsync();
        public Task<TurboFormModel> GetTurboFormByIdAsync(int turboId);
        public Task EditTurboAsync(int turboId, TurboFormModel model);
        public Task<int> AddTurboAsync(TurboFormModel model);
        public Task DeleteTurboAsync(int turboId);
    }
}
