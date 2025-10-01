namespace Weather.Contracts.Responses;

public class WeatherResponse
{
    public City City { get; set; }
    public List<WeatherByDay> List { get; set; }
}
public class WeatherByDay
{
    public Temp Temp { get; set; }
    public List<Item> Weather { get; set; }
}

public class Temp
{
    public float Day { get; set; }
    public float Min { get; set; }
    public float Max { get; set; }
    public float Night { get; set; }
    public float Eve { get; set; }
    public float Morn { get; set; }
}

public class Item
{
    public string Main { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class City
{
    public string Name { get; set; }
    public string Country { get; set; }
}
