using ECFPerformance.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static ECFPerformance.Constants.GeneralApplicationConstants;

namespace ECFPerformance.Web.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string email)
        {
            using IServiceScope scopedServices = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopedServices.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();


            Task.Run(async () =>
            {
                ApplicationUser adminUser =
                    await userManager.FindByEmailAsync(email);

                if (await roleManager.RoleExistsAsync(AdminRoleName))
                {
                    if(!await userManager.IsInRoleAsync(adminUser, AdminRoleName))
                    {
                        await userManager.AddToRoleAsync(adminUser, AdminRoleName);
                    }

                    return;
                }

                IdentityRole<Guid> role =
                    new IdentityRole<Guid>(AdminRoleName);

                await roleManager.CreateAsync(role);

                await userManager.AddToRoleAsync(adminUser, AdminRoleName);
            })
            .GetAwaiter()
            .GetResult();

            return app;
        }
    }
}
