using System;

class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, double lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        // Distance = Speed * Time
        return _speedMph * (LengthMinutes / 60); // Convert minutes to hours
    }
    public override double GetSpeed()
    {
        return _speedMph; // Speed in miles per hour
    }
    public override double GetPace()
    {
        // Pace = Time / Distance
        return LengthMinutes / GetDistance(); // Pace in minutes per mile
    }
    
}