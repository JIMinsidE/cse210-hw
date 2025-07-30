using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Console.WriteLine("Default Fraction: " + fraction1.GetfractionString());
        Console.WriteLine("Decimal Value: " + fraction1.GetDecimalValue());

        Fractions fraction2 = new Fractions(1);
        Console.WriteLine("Whole Number Fraction: " + fraction2.GetfractionString());
        Console.WriteLine("Decimal Value: " + fraction2.GetDecimalValue());

        Fractions fraction3 = new Fractions(2, 5);
        Console.WriteLine("Custom Fraction: " + fraction3.GetfractionString());
        Console.WriteLine("Decimal Value: " + fraction3.GetDecimalValue());

        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine("Another Custom Fraction: " + fraction4.GetfractionString());
        Console.WriteLine("Decimal Value: " + fraction4.GetDecimalValue());
    }
}