using Facet;
using Weather.Application.Models.Weather;

namespace Weather.Api.Mapping;

public partial class Facets
{
    [Facet(typeof(WeatherByPeriod))]
    public partial class WeatherByPeriodDto;
}
