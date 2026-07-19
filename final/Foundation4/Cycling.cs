using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, string type, double speed) : base(date, minutes, type)
    {
        _speed = speed;
    }
    
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round((_speed / 60), 2);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {GetDistance()} miles\nSpeed: {GetSpeed()}mph\nPace: {GetPace()} miles/min";
    }
}