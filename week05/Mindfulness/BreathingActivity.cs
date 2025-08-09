using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {

    }

    public void Breath(int seconds, int sleepTime = 500)
    {
        for (int i = 0; i < seconds; i++)
        {
            string breath = "";
            for(var count = 0; count < i; count++)
            {
                breath += "O";
            }
            Console.Write(breath);
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in... ");
            Breath(5);
            // ShowCountDown(3);
            Console.WriteLine("\nBreathe out... ");
            Breath(5, 1000); // 
            // ShowCountDown(5);
            
        }

        DisplayEndingMessage();
    }
}
