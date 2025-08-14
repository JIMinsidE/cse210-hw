abstract class Activity
{
    private DateTime _date;
    private double _lengthInMinutes;

    public double LengthMinutes => _lengthInMinutes;
    public DateTime Date => _date;

    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // mph
    public abstract double GetPace();     // min per mile

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({LengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}