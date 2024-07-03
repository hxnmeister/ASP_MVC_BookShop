using ASP_MVC_BookShop.Filters;
using ASP_MVC_BookShop.Services.Implementations;
using ASP_MVC_BookShop.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ASP_MVC_BookShop.Extensions
{
    public static class ScopedExtensions
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            services.TryAddScoped<IFileActions, FileActionsService>();
            services.TryAddScoped<ExceptionCatcherAttribute>();
            services.TryAddScoped<ActionLoadTimeFilter>();
            services.TryAddScoped<IRandomQuote, RandomQuoteService>();
            services.TryAddScoped<IRecommendation, RecommendationService>();

            return services;
        }
    }
}
