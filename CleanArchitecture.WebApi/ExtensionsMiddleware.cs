using CleanArchitecture.Domain.Modules.Accounts.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.WebApi
{
    public static class ExtensionsMiddleware
    {
        public static async Task CreateFirstUser(WebApplication app)
        {
            using var scoped = app.Services.CreateScope();
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole<int>("Admin"));
            }

            if (!await userManager.Users.AnyAsync(u => u.UserName == "knnaliev"))
            {
                var user = new AppUser { UserName = "knnaliev", Ad = "Kenan Aliyev" };
                await userManager.CreateAsync(user, "nepster0488");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
