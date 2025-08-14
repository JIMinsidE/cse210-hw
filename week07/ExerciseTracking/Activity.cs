abstract class Activity
{
    private DateTime _date;
    private double _lengthInMinutes;

    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

        public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile
}