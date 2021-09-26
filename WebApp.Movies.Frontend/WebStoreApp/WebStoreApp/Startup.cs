using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Data;
using WebApp.Data.ApiCallService;
using WebApp.Model;
using MatBlazor;
using Blazored.LocalStorage;
using WebApp.Model.Account;
using Microsoft.AspNetCore.Components.Authorization;
using System.Reflection;
using Blazored.Toast;

namespace WebApp
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



            string uri = Configuration.GetValue<string>("WebAPI");


            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddMatBlazor();
            services.AddHttpClient();

            services.AddHttpClient("webapi", c =>
            {
                c.BaseAddress = new Uri(uri);
            });


            services.AddScoped(typeof(IApiCallService<>), typeof(ApiCallService<>));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddBlazoredLocalStorage();

            services.AddScoped<AppState>();

            services.AddOptions();

            services.AddAuthorizationCore();

            services.AddScoped(typeof(AuthenticationStateProvider), typeof(LocalAuthenticationStateProvider));

            services.AddBlazoredToast();

            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
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

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
