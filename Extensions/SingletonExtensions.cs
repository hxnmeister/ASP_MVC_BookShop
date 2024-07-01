using ASP_MVC_BookShop.Services.Implementations;
using ASP_MVC_BookShop.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ASP_MVC_BookShop.Extensions
{
    public static class SingletonExtensions
    {
        public static IServiceCollection AddSingletonServices (this IServiceCollection services)
        {
            services.AddSingleton<IBookStorage>(provider => new BookStorageService(@"./wwwroot/Files/bookStorage.json"));
            services.AddSingleton<IQuote, QuoteService>();
            services.AddSingleton<IQuoteOfDay, QuoteOfDayService>();
            //При заміні реалізації на DaysOfWeekService або MonthService будемо отримувати різні дані на головній сторінці (BookController - Index)
            services.AddSingleton<ICalendarValues, DaysOfWeekService>();

            return services;
        }
    }
}
