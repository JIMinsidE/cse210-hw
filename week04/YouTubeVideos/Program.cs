using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Not Rick Rolling", "RockinGRill", 953);
        video1.AddComment(new Comment("It's OK Rick take your time to remind lyrics", "Fring Gus"));
        video1.AddComment(new Comment("It's time to cook!", "User no user"));
        video1.AddComment(new Comment("Keep up reminding lyrics, Rick!", "Username"));
        videos.Add(video1);

        Video video2 = new Video("Learning C#", "CodeMaster", 678);
        video2.AddComment(new Comment("Very informative, but better to buy a new mic", "TechGurus"));
        video2.AddComment(new Comment("I learned a lot from this.", "DevNerd"));
        videos.Add(video2);

        Video video3 = new Video("Cooking Tips", "ChefnotDelight", 2071);
        video3.AddComment(new Comment("These recipes are amazing!", "Fododie123"));
        video3.AddComment(new Comment("Can't wait to try these out!", "HomerCook"));
        video3.AddComment(new Comment("Love the way he cooks!", "CulynotnaryFan"));
        video3.AddComment(new Comment("Great tips for beginners.", "NewbayChef"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine("------------------Video Section------------------");
            Console.WriteLine($"\nVideo Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");
            Console.WriteLine("------------------Comments Section------------------");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: \n {comment._commentText}");
            }
        }


    }
}