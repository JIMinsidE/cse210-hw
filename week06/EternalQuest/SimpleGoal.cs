public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name}: {Description} (Points: {Points})");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        IsCompleted = true;
    }
}