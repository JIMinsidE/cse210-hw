using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your mark: ");
        string mark = Console.ReadLine();
        int number = int.Parse(mark);
        string letter = "";
        
        if (number < 0 || number > 100)
            {
                Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                return; 
            }

            

            if (number >= 90)
            {
                letter = "A";
            }
            else if (number >= 80)
            {
                letter = "B";
            }
            else if (number >= 70)
            {
                letter = "C";
            }
            else if (number >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            
        int lastDigit = number % 10; 

            if (letter != "A" && lastDigit >= 7)
            {
                letter += "+";
            }
            else if (letter != "F" && lastDigit <= 3)
            {
                letter += "-";
            }
        Console.WriteLine($"Your letter grade is:{letter}");
    }
}