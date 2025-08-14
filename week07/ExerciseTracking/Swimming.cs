class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double kilometers = _laps * 50 / 1000.0;
        return kilometers * 0.62; // convert to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }
    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}