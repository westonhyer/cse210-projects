using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double minutes, string type, double distance) : base (date, minutes, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return base.GetSpeed();
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