using taxajuros.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using taxajuros.Services;

namespace taxajuros.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();

            return services;
        }
    }
}
