public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    public double GetWidth()
    {
        return _width;
    }

    public double SetWidth(double width)
    {
        _width = width;
        return _width;
    }

    public double GetHeight()
    {
        return _height;
    }

    public double SetHeight(double height)
    {
        _height = height;
        return _height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}