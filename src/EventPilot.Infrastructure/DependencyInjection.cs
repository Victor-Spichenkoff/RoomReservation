using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace EventPilot.Infrastructure;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
            IConfiguration config
        )
    {
        
        return services;
    }
}