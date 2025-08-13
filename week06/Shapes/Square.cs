using System;
public class Square : Shape
{
    private double _sideLength;

    public Square(string color, double sideLength) : base(color)
    {
        _sideLength = sideLength;
    }

    public double GetSideLength()
    {
        return _sideLength;
    }

    public double SetSideLength(double sideLength)
    {
        _sideLength = sideLength;
        return _sideLength;
    }

    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}