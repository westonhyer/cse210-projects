using System;

public class Activity
{
    private string _date;
    private double _minutes;

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    public string GetSummary()
    {
        return "";
    }
}