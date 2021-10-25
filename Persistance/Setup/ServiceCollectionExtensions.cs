using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.WeightGoalRepository;
using Persistence.Settings;

namespace Persistence.Setup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services
                .AddTransient<IWeightGoalRepository, WeightGoalRepository>()
                .AddTransient<IDatabaseSettings, DatabaseSettings>();

            return services;
        }
    }
}