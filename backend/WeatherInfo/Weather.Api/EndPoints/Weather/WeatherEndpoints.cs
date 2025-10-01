using Weather.Api.Mapping;
using Weather.Application.Services;

namespace Weather.Api.EndPoints.Weather;

public static class WeatherEndpoints
{
    public static void MapWeatherEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("weathers");
        
        group.MapGet("/", async (double latitud, double longitud, int dias, IWeatherService _weatherService, CancellationToken token) =>
        {
            var result = await _weatherService.GetWeatherByPeriod(latitud, longitud, dias, token);
            return result is not null ? Results.Ok(result.MapToResponse()) : Results.NotFound();
            //return $"Search query: {latitud}, Page: {longitud}, Días: {dias}";
        });
    }
}
