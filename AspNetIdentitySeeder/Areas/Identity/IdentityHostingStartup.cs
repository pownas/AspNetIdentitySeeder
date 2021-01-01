using System;
using AspNetIdentitySeeder.Areas.Identity.Data;
using AspNetIdentitySeeder.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AspNetIdentitySeeder.Areas.Identity.IdentityHostingStartup))]
namespace AspNetIdentitySeeder.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppNameContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AppNameContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AppNameContext>();
            });
        }
    }
}