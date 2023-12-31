﻿using ECFPerformance.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.Services.Contracts
{
    public interface IUserService
    {
        public Task<IEnumerable<AllUsersViewModel>> GetAllUsers();
    }
}
