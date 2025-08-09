using System;

class Program
{
    static void Main(string[] args)
    {
        bool wantToQuit = false;
        while (wantToQuit == false)
        {
            Console.WriteLine("Hello user! Welcome to the Mindfulness Program.\nToday we will focus on mindfulness activities to help you relax and reflect.");
            Console.WriteLine("Please choose an activity to start:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity4. Exit");

            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity.Run();
                    break;

                case "2":
                    ListingActivity.Run();
                    break;

                case "3":
                    ReflectionActivity.Run();
                    break;

                case "4":
                    Console.WriteLine("Thank you for launching this program. We hope to it helped you. Goodbye!");
                    wantToQuit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}