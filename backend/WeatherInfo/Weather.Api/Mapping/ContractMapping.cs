using Facet.Extensions;
using Weather.Application.Models.Weather;
using Weather.Contracts.Responses;
using static Weather.Api.Mapping.Facets;

namespace Weather.Api.Mapping;

public static class ContractMapping
{
       
    public static WeatherByPeriodDto MapToResponse(this WeatherByPeriod weather)
    {
        var dto = weather.ToFacet<WeatherByPeriod, WeatherByPeriodDto>();
        return dto;
    }
}
