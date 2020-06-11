using Microsoft.Extensions.DependencyInjection;

namespace PrimeGenerator.Core
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddSOSPrimeGenerator(this IServiceCollection services)
        {
            services.AddTransient<IPrimeGenerator, SieveOfSundaramPrimeGenerator>();
            return services;
        }

        public static IServiceCollection AddStandardPrimeGenerator(this IServiceCollection services)
        {
            services.AddTransient<IPrimeGenerator, StandardPrimeGenerator>();
            return services;
        }
    }
}
