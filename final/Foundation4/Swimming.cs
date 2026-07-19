using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, string type, int laps) : base(date, minutes, type)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round((_laps * 50.0 / 1000 * 0.62), 2);
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return base.GetPace();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {GetDistance()} miles\nSpeed: {GetSpeed()}mph\nPace: {GetPace()} min/mile";
    }
}