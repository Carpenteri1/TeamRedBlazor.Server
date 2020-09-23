using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityProvider.Server.Configuration;
using IdentityServer4;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace IdentityProvider.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //add identity server here
            services.AddIdentityServer()
                .AddSigningCredential(new X509Certificate2(@"C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\combined.pfx","004000"))
                .AddTestUsers(InMemoryConfiguration.TestUsers().ToList())
                .AddInMemoryApiResources(InMemoryConfiguration.ApiResource())
                .AddInMemoryClients(InMemoryConfiguration.Clients());
            
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();    
            app.UseIdentityServer();
        }
    }
}
