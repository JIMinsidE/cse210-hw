using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(new DateTime(2022, 11, 3), 30, 3.0, 6.0); // Added speedInMph argument
        activities.Add(run1);

        Cycling cycl1 = new Cycling(new DateTime(2022, 11, 3), 30, 12.0);
        activities.Add(cycl1);

        Swimming swim1 = new Swimming(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(swim1);
        

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}