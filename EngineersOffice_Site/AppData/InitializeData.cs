using EngineersOffice_Site.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EngineersOffice_Site.AppData
{
    public static class InitializeData
    {
        public static async Task InitializeAsync(UserManager<EngineersOfficeUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "admin123";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                EngineersOfficeUser admin = new EngineersOfficeUser { Email = adminEmail, UserName = adminEmail };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
