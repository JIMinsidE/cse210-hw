using System;

class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, double lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }
}