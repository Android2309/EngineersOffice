using System;
using EngineersOffice_Site.Areas.Identity.Data;
using EngineersOffice_Site.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EngineersOffice_Site.Areas.Identity.IdentityHostingStartup))]
namespace EngineersOffice_Site.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EngineersOfficeUsersDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EngineersOfficeDBContextConnection")));

                services.AddDefaultIdentity<EngineersOfficeUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                })
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<EngineersOfficeUsersDBContext>();
            });
        }
    }
}