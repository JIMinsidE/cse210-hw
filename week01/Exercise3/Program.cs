using System;

class Program

{
    
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 100);
    int guess = 0, count = 0;
    
    while (guess != number)
    {
      Console.WriteLine("Guess the number");
      string tguess = Console.ReadLine();
      guess = int.Parse(tguess);
      if (guess > number){
        Console.WriteLine("Lower");
      }
      else if (guess < number){
        Console.WriteLine("Higher");
      }
      count +=1;
    }
    Console.WriteLine("You guessed it!");
    Console.WriteLine($"Number of guesses: {count}");
  }
    
}