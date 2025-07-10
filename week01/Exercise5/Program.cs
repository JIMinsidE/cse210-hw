using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine($"Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine($"Please enter your favorite number:");
        string input_number = Console.ReadLine();
        int number = int.Parse(input_number);
        return number;
    }

    static double SquareNumber(int number)
    {
        double square = Math.Pow(number, 2);
        return square;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(number)}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);
    }
}