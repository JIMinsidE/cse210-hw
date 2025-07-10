using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers;
        numbers = new List<int>();
        
        string exit_Number = "1";
        while (exit_Number != "0")
        {
            Console.WriteLine("Enter number: ");
            exit_Number = Console.ReadLine();
            int input_Number = int.Parse(exit_Number);
            if (input_Number != 0){
            numbers.Add(input_Number);
            }
        }

        numbers.Sort();
        int numbers_sum = 0;
        int min_number = 1;

        foreach (int number in numbers)
        {
            numbers_sum += number;

            if (number > 0 && number <= min_number){
                min_number = number;
            } 
        }
        Console.WriteLine($"The sum is: {numbers_sum}");
        Console.WriteLine($"The average is: {numbers_sum/numbers.Count}");
        Console.WriteLine($"The larges number is: {numbers.ElementAt(numbers.Count-1)}");
        Console.WriteLine($"The smallest positive number is: {min_number}");
        Console.WriteLine("The sorted list is:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}