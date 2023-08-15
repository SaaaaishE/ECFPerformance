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
    public class UserService : IUserService
    {
        private EcfDbContext dbContext;

        public UserService(EcfDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllUsersViewModel>> GetAllUsers()
        {
            return await dbContext.Users
                .Select(u => new AllUsersViewModel
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    PhoneNumber = u.PhoneNumber,
                    Id = u.Id,
                })
                .ToArrayAsync();
        }
    }
}
