using ECFPerformance.Infrastructure.Data.Models;
using ECFPerformance.Infrastructure.Data.Models.Engine;
using ECFPerformance.Infrastructure.Data.Models.Projects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECFPerformance.Infrastructure.Data.Seed;

namespace ECFPerformance.Infrastructure.Data
{
    public class EcfDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public EcfDbContext(DbContextOptions<EcfDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ConnectingRod> ConnectingRods { get; set; }
        public DbSet<ProjectCar> ProjectCars { get; set; }
        public DbSet<Turbo> Turbos { get; set; }
        public DbSet<TurboScrollType> ScrollTypes { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasData(Seeder.SeedAdmin());

            builder.Entity<ConnectingRodEngineType>()
                .HasKey(x => new { x.CompatibleEngineId, x.CompatibleRodId });


            builder.Entity<EngineType>()
                .HasData(Seeder.SeedEngineTypes());

            builder.Entity<TurboScrollType>()
                .HasData(Seeder.SeedTurboScrollTypes());

            builder.Entity<ConnectingRodBeamType>()
                .HasData(Seeder.SeedBeamTypes());

            builder.Entity<Category>()
                .HasData(Seeder.SeedCategories());

            builder.Entity<Turbo>()
                .HasData(Seeder.SeedTurbos());

            builder.Entity<ConnectingRod>()
                .HasData(Seeder.SeedConnectingRods());

            builder.Entity<ConnectingRodEngineType>()
                .HasData(Seeder.SeedRodsEngines());

            base.OnModelCreating(builder);
        }
    }
}