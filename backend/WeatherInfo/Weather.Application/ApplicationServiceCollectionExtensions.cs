using Microsoft.Extensions.DependencyInjection;
using Weather.Application.Configurations;
using Weather.Application.Repositories;
using Weather.Application.Services;

namespace Weather.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services, string apiKey, string url)
    {
        services.AddSingleton<IWeatherRepository, WeatherRepository>();
        services.AddSingleton<IWeatherService, WeatherService>();

        services.AddSingleton<IOpenWeatherSettings>(_ =>
            new OpenWeatherSettings(apiKey, url));

        return services;
    }
}
