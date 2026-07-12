using System;

public class Cycleing : Activity
{
    private double _speed;
    
    public override double GetDistance()
    {
        return 1;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}