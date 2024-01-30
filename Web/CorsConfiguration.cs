using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace VideoGameHub.BuildingBlock.Web;

public static class CorsConfiguration
{
    public static IServiceCollection AddCustomCors(this IServiceCollection services, string policyName, params string[] origins)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(policyName,
                builder =>
                {
                    builder.WithOrigins(origins)
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });

        return services;
    }

    public static WebApplication UseCustomCors(this WebApplication webApplication, string policyName)
    {
        webApplication.UseCors(policyName);
        return webApplication;
    }
}