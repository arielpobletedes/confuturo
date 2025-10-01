using Weather.Application.Models.Base;

namespace Weather.Application.Models.Weather;

public class WeatherByPeriod
{
    public City city { get; set; }
    public List<WeatherByDay> list { get; set; }
}
