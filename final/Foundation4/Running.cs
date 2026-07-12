using System;

public class Running : Activity
{
    private double _distance;

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
}