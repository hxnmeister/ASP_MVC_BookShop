using ASP_MVC_BookShop.Extensions;
using ASP_MVC_BookShop.Filters;
using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.Services.Implementations;
using ASP_MVC_BookShop.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ASP_MVC_BookShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            const string KEY_DB_NAME = "DefaultConnection";

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingletonServices();
            services.AddScopedServices();
            services.AddMemoryCache();
            services.AddDbContext<BookShopDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString(KEY_DB_NAME)));

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ActionLoadTimeFilter));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
