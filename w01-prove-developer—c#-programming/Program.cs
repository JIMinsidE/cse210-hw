using System;
using System.Runtime.InteropServices;
class HelloWorld {
  
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static void UsernameInput()
    {
        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        return fname
    }
    static void UsersurnameInput()
    {
        Console.WriteLine("What is your first name? ");
        string lname = Console.ReadLine();
        return lname
    }
    static int AddNumbers(int first, int second)
  {
    fullname = first + " " +second;
    return fullname;
  }

  static void Main() 
  {
    DisplayMessage();
    /*
    Task 1. 
    */
    
    
    Console.WriteLine("What is your last name? ");
    string lname = Console.ReadLine();
    
    Console.WriteLine($"Your name is {fname}, {fname} {lname}");
    
    /*
    Task 2. 
    */
    Console.WriteLine("Input your number");
    string tnumber = Console.ReadLine();
    int number = int.Parse(tnumber);
    int guess = 0;
    while (guess != number)
    {
      Console.WriteLine("Guess the number");
      string tguess = Console.ReadLine();
      guess = int.Parse(tguess);
      if (guess > number){
        
      }
    }
    Console.WriteLine(number);
  }
}