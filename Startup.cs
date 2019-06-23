using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Validators;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddSingleton<HttpContextAccessor>();
            
            services.AddMvc(options =>
            {
                options.OutputFormatters.Clear();
                options.OutputFormatters.Add(new JsonOutputFormatter(new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                }, ArrayPool<char>.Shared));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddFluentValidation();

            // Add validators
            
            services.AddTransient<IValidator<LoginViewModel>, LoginViewModelValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterViewModelValidator>();

            
            // Add singleton services
            
            services.AddTransient<UserService>();
            services.AddTransient<AuthenticateService>();
            services.AddTransient<BooksService>();
            
            // Add database context
            
            services.AddDbContext<Context>(options =>
                options.UseMySql(Configuration["DefaultConnections"]));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "login",
                    template: "controller=Login/{action=Index}");
                
                routes.MapRoute(
                    name: "register",
                    template: "controller=Register/{action=Index}");
                
                routes.MapRoute(
                    name: "books",
                    template: "controller=Books/{action=Index}");
            });
        }
    }
}