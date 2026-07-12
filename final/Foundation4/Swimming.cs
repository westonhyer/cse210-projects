using System;

public class Swimming : Activity
{
    private int _laps;

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
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