using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle rec1 = new Rectangle("Red", 5, 10);
        shapes.Add(rec1);

        Circle cr1 = new Circle("Purple", 3);
        shapes.Add(cr1);

        Square sq1 = new Square("Dark Green", 4);
        shapes.Add(sq1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}