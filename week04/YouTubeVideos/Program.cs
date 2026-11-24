using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Learn C# Classes", "CodeWithTadala", 640);
        video1.AddComment(new Comment("Chikondi Banda", "This made abstraction so much easier to understand."));
        video1.AddComment(new Comment("Brian Miller", "Clear explanation and great examples."));
        video1.AddComment(new Comment("Grace Phiri", "Thank you for posting this tutorial!"));
        videos.Add(video1);

        Video video2 = new Video("Exploring Lake Malawi", "TravelMalawi", 825);
        video2.AddComment(new Comment("Mphatso Mwale", "Cape Maclear looks amazing in this video."));
        video2.AddComment(new Comment("Sarah Jenkins", "Adding Malawi to my travel list."));
        video2.AddComment(new Comment("Kelvin Gondwe", "The drone shots over the water are awesome."));
        videos.Add(video2);

        Video video3 = new Video("Morning Workout Routine", "FitLifeDaily", 510);
        video3.AddComment(new Comment("Amina Yusuf", "Just finished this workout, feeling great!"));
        video3.AddComment(new Comment("Devon Brooks", "Simple exercises that anyone can do at home."));
        video3.AddComment(new Comment("Tamara Nkhoma", "Doing this every morning this week."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
