using Weather.Application.Models.Weather;

namespace Weather.Application.Services;

public interface IWeatherService
{
    Task<WeatherByPeriod> GetWeatherByPeriod(double latitud, double longitud, int dias, CancellationToken token = default);
}
