using calculajuros.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using calculajuros.Services;

namespace calculajuros.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICalculoJurosService, CalculoJurosService>();          

            return services;
        }
    }
}