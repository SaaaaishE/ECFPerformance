using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECFPerformance.Infrastructure.Data
{
    public class EcfDbContext : IdentityDbContext
    {
        public EcfDbContext(DbContextOptions<EcfDbContext> options)
            : base(options)
        {
        }
    }
}