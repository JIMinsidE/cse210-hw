using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<Scripture> _scriptures;

    static void Main(string[] args)
    {
        LoadScripturesFromFile("scriptures.txt");
        var random = new Random();
        var currentScripture = _scriptures[random.Next(_scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            if (!currentScripture.IsCompletelyHidden())
            {
                currentScripture.HideRandomWords(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!");
                Console.WriteLine(currentScripture.GetDisplayText());
                break;
            }
        }
    }
    private static void LoadScripturesFromFile(string filePath)
{
    _scriptures = new List<Scripture>();
    if (!System.IO.File.Exists(filePath))
    {
        Console.WriteLine($"File not found: {filePath}");
        return;
    }

    foreach (var line in System.IO.File.ReadAllLines(filePath))
    {
        if (string.IsNullOrWhiteSpace(line)) continue;
        var parts = line.Split('|');
        if (parts.Length == 2)
        {
            string referenceStr = parts[0].Trim();
            string text = parts[1].Trim();
            // Parse referenceStr into book, chapter, verse, and optional endVerse
            // Example referenceStr: "John 3:16" or "John 3:16-17"
            string book = "";
            int chapter = 0;
            int verse = 0;
            int? endVerse = null;

            int lastSpace = referenceStr.LastIndexOf(' ');
            if (lastSpace > 0)
            {
                book = referenceStr.Substring(0, lastSpace);
                string chapterVerse = referenceStr.Substring(lastSpace + 1);
                var chapterVerseParts = chapterVerse.Split(':');
                if (chapterVerseParts.Length == 2)
                {
                    chapter = int.Parse(chapterVerseParts[0]);
                    var verseParts = chapterVerseParts[1].Split('-');
                    verse = int.Parse(verseParts[0]);
                    if (verseParts.Length == 2)
                    {
                        endVerse = int.Parse(verseParts[1]);
                    }
                }
            }

            Reference reference = new Reference(book, chapter, verse, endVerse);
            _scriptures.Add(new Scripture(reference, text));
        }
    }
}
}
