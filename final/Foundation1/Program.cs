using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Construction 101", "Bob the Builder", 900);
        video1.AddComment(new Comment("Scoop", "Great video, Bob!"));
        video1.AddComment(new Comment("Muck", "Looks like the project is going well!"));
        video1.AddComment(new Comment("Dizzy", "Would you look at all that concrete!"));
        videos.Add(video1);

        Video video2 = new Video("Good Morning Zarahemla", "Nehor", 600);
        video2.AddComment(new Comment("Alma", "Thou art condemed to die, according to the law."));
        video2.AddComment(new Comment("Ghost of Gideon", "If only I was a younger man..."));
        video2.AddComment(new Comment("NehorFan33", "His teachings are the best! I can do whatever I want!"));
        videos.Add(video2);

        Video video3 = new Video("C# Syntax", "Microsoft", 10000);
        video3.AddComment(new Comment("CodyTheCoder", "Thanks for the explanation! I've never been more excited to code!"));
        video3.AddComment(new Comment("StrugglingStudent22", "Wait, there's no 'for i in range loop??' Python, why hast thou forsaken me?"));
        video3.AddComment(new Comment("CSE210Master", "Brother Godderidge's class did it better..."));
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}