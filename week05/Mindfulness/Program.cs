using System;

// Well this time I enhanced the programm by adding breathing functionality
// Exhaling time is longer than inhaling time by chznging the sleep time
// I also added a spinner to the breathing activity to make it more interactive

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
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter the number of your choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();

                    break;

                case "2":
                    new ListingActivity().Run();
                    break;

                case "3":
                    new ReflectingActivity().Run();
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