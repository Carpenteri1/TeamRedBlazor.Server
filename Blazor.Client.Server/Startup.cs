using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using TeamRedBlazor.Client.Server.Data.Services;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection.Metadata.Ecma335;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace TeamRedBlazor.Client.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSingleton<HttpClient>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<RealEstateService>();
            services.AddSingleton<UserService>();

            services.AddServerSideBlazor().AddCircuitOptions(options =>
            { options.DetailedErrors = true; });


            services.AddAuthentication();


            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme,
                options =>
                {
                    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.Authority = "https://localhost:44313";
                    options.ClientId = "teamredclientserver";
                    options.ClientSecret = "superSecret";
                    options.ResponseType = "code";
                    options.UsePkce = true;//true when using GrandTypes code
                    options.Scope.Add("openid");
                    options.Scope.Add("profile");
                    //options.Scope.Add("offline_access");
                    //options.CallbackPath = "/localhost:44313/signin-oidc";
                    options.SaveTokens = true;
                    options.GetClaimsFromUserInfoEndpoint = true;

                });
            services.AddMvc();
            services.AddControllers();
            services.AddSwaggerGen(options => 
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TeamRed Swagger Doc",
                    Version = "v1",
                    Description = "An API to perform operations",
                    Contact = new OpenApiContact
                    {
                        Name = "The Auther",
                        Email = "TheAuther@gmail.com",
                    }
        });
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
    }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
                
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //c.InjectStylesheet("/swagger-ui/custom.css");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TeamRed Swagger API V1");
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
