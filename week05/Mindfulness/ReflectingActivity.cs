using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base
    }

    private string GetRandomPrompt()
    {

    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string? item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }
        return items;
    }

    public override void Run()
    {
    
    }
}
