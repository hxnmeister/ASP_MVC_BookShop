using ASP_MVC_BookShop.Filters;
using ASP_MVC_BookShop.Services;
using ASP_MVC_BookShop.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ASP_MVC_BookShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton<IBookStorage>(provider => new BookStorageService(@"./wwwroot/Files/bookStorage.json"));
            services.AddSingleton<IQuote, QuoteService>();
            services.AddSingleton<IQuoteOfDay, QuoteOfDayService>();
            //При заміні реалізації на DaysOfWeekService або MonthService будемо отримувати різні дані на головній сторінці (BookController - Index)
            services.AddSingleton<ICalendarValues, DaysOfWeekService>();
            services.AddScoped<IFileActions, FileActionsService>();
            services.AddScoped<ExceptionCatcherAttribute>();
            services.AddScoped<ActionLoadTimeFilter>();
            services.AddScoped<IRandomQuote, RandomQuoteService>();

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
