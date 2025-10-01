using Weather.Application.Models.Weather;
using Weather.Application.Repositories;

namespace Weather.Application.Services;

public class WeatherService : IWeatherService
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherService(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public Task<WeatherByPeriod> GetWeatherByPeriod(double latitud, double longitud, int dias, CancellationToken token = default)
    {
        return _weatherRepository.GetWeatherByPeriod(latitud, longitud, dias, token);
    }
}
