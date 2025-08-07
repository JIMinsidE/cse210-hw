using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Not Rick Rolling", "RockinGRill", 953);
        video1.AddComment(new Comment("This is a great video!", "User1"));
        video1.AddComment(new Comment("I love the content!", "User2"));
        video1.AddComment(new Comment("Keep up the good work!", "User3"));
        videos.Add(video1);

        Video video2 = new Video("Learning C#", "CodeMaster", 1200);
        video2.AddComment(new Comment("Very informative!", "TechGuru"));
        video2.AddComment(new Comment("I learned a lot from this.", "DevNerd"));
        videos.Add(video2);

        Video video3 = new Video("Cooking Tips", "ChefDelight", 800);
        video3.AddComment(new Comment("These recipes are amazing!", "Foodie123"));
        video3.AddComment(new Comment("Can't wait to try these out!", "HomeCook"));
        video3.AddComment(new Comment("Love the presentation!", "CulinaryFan"));
        video3.AddComment(new Comment("Great tips for beginners.", "NewbieChef"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Video Tirtle: {video._title}");
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