using System;
using System.Collections.Generic;
 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers;
        numbers = new List<int>();
        
        string exit_Number = "";
        while (exit_Number != "0")
        {
            Console.WriteLine("Enter number: ");
            exit_Number = Console.Readline();
            int input_Number = parseInt(exit_Number);
            numbers.Add(input_Number);
            
        }

    }
}