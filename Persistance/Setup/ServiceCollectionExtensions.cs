using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using Persistence.Settings;

namespace Persistence.Setup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services
                .AddTransient<IWeightGoalRepository, WeightGoalRepository>()
                .AddTransient<IDatabaseSettings, WeightGoalSettings>();

            return services;
        }
    }
}