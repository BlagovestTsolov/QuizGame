using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using static QuizGame.Core.Constants.AdminConstants;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder builder)
        {
            using var scopedServices = builder.ApplicationServices.CreateAsyncScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminRole))
                {
                    return;
                }

                var role = new IdentityRole { Name = AdminRole };
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByNameAsync(AdminEmail);
                if (admin != null)
                {
                    await userManager.AddToRoleAsync(admin, role.Name);
                }
            })
                .GetAwaiter()
                .GetResult();

            return builder;
        }
    }
}
