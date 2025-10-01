using Weather.Application.Models.Weather;

namespace Weather.Application.Repositories;

public interface IWeatherRepository
{
    Task<WeatherByPeriod> GetWeatherByPeriod(double latitud, double longitud, int dias, CancellationToken token = default);

}
