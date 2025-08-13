using System;

public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double SetRadius(double radius)
    {
        _radius = radius;
        return _radius;
    }
    public override double GetArea()
    {
        double area = Math.Round(Math.PI * _radius * _radius, 2);
        return area;
    }

}