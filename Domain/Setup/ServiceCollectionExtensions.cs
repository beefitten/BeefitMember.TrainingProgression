using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Setup
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddTransient<IWeightGoalService, WeightGoalService>();

            return services;
        }
    }
}