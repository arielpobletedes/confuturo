using Weather.Application.Models.Config;

namespace Weather.Application.Configurations;

public interface IOpenWeatherSettings
{
    string Url (CancellationToken token = default);
    string ApiKey(CancellationToken token = default);
}

public class OpenWeatherSettings : IOpenWeatherSettings
{

    private readonly ExternalApiSettings _externalSetting;

    public OpenWeatherSettings(string apiKey, string url)
    {
        _externalSetting = new() { ApiKey = apiKey, Url = url };
    }
    public string Url(CancellationToken token)
    {
        return _externalSetting.Url;
    }
    public string ApiKey(CancellationToken token)
    {
        return _externalSetting.ApiKey;
    }
}
