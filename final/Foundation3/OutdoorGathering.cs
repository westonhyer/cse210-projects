using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string type, string date, string time, Address address, string weather) : base(type, title, date, time, address)
    {
        _weather = weather;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather is expected to be {_weather}";
    }
}