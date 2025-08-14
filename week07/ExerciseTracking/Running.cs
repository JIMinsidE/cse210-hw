class Running : Activity
{
    private double _distanceInMiles;
    private double _speedInMph;

    public Running(DateTime date, double lengthInMinutes, double distanceInMiles, double speedInMph)
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
        _speedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return _distanceInMiles; // Distance in miles
    }

    public override double GetSpeed()
    {
         // Convert minutes to hours
        return (GetDistance() / LengthMinutes) * 60; // Speed in miles per hour
    }

    public override double GetPace()
    {
        return LengthMinutes / _distanceInMiles; // Pace in minutes per mile
    }
}