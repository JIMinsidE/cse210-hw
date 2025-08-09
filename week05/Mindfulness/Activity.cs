public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("Consider to enter duration in seconds: ");

        _duration = int.Parse(Console.ReadLine());
        switch (_duration)
        {
            case 0:
                Console.WriteLine("Duration cannot be zero. Setting to default of 31 seconds.");
                _duration = 31;
                break;
            case < 1:
                Console.WriteLine("Duration must be at least 1 second. Setting to default of 31 seconds.");
                _duration = 31;
                break;
            case > 60:
                Console.WriteLine("Duration is too long. Setting to maximum of 60 seconds.");
                _duration = 60;
                break;
            default:
                _duration = 30;
                break;
        }
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        string[] sequence = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(sequence[i % sequence.Length]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
}