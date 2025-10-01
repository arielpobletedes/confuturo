using System.Text.Json;
using Weather.Application.Configurations;
using Weather.Application.Models.Weather;

namespace Weather.Application.Repositories;

public class WeatherRepository : IWeatherRepository
{
    private readonly IOpenWeatherSettings _apiSettings;

    public WeatherRepository(IOpenWeatherSettings apiSettings)
    {
        _apiSettings = apiSettings;
        var a = _apiSettings.Url();
    }

    public async Task<WeatherByPeriod> GetWeatherByPeriod(double latitud, double longitud, int dias, CancellationToken token = default)
    {
        var url = $"{_apiSettings.Url()}lat={latitud}&lon={longitud}&cnt={dias}&units=metric&appid={_apiSettings.ApiKey()}";

        var client = new HttpClient();

        //try
        //{
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            WeatherByPeriod weather = JsonSerializer.Deserialize<WeatherByPeriod>(body);
            return weather;
        }
    }
    //catch (HttpRequestException ex)
    //{
    //    Console.WriteLine($"Request failed: {ex.Message}");
    //    if (ex.StatusCode.HasValue)
    //    {
    //        Console.WriteLine($"HTTP Status Code: {(int)ex.StatusCode}");
    //    }
    //    // Further error handling based on status code or other exception details
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    //}
    //return null;
    //}
}
