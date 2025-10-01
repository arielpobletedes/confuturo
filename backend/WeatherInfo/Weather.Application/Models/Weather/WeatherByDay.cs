using Weather.Application.Models.Base;

namespace Weather.Application.Models.Weather;

public class WeatherByDay
{
    public Temp temp { get; set; }
    public List<Item> weather { get; set; }
}
