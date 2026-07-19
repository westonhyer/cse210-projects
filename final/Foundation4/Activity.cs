using System;

public class Activity
{
    private string _date;
    private double _minutes;
    private string _type;

    public Activity(string date, double minutes, string type)
    {
        _date = date;
        _minutes = minutes;
        _type = type;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return Math.Round(((GetDistance() / _minutes) * 60), 2);
    }

    public virtual double GetPace()
    {
        return Math.Round((60 / GetSpeed()), 2);
    }

    public virtual string GetSummary()
    {
        return $"{_date} - {_type} ({_minutes} min)\n";
    }

    public double GetMinutes()
    {
        return _minutes;
    }
}