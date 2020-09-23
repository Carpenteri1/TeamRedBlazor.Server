using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeamRedBlazor.Client.Server.Areas.Identity.Data;

[assembly: HostingStartup(typeof(TeamRedBlazor.Client.Server.Areas.Identity.IdentityHostingStartup))]
namespace TeamRedBlazor.Client.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TeamRedBlazorClientServerContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TeamRedBlazorClientServerContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TeamRedBlazorClientServerContext>();
            });
        }
    }
}