using EventPilot.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventPilot.Application;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<TestService, TestService>();
        
        return services;
    }
}