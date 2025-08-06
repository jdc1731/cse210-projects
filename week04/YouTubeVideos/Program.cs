using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("C# Tutorial for Beginners", "Tech Guru", 600);
        Video video2 = new Video("Cooking Perfect Pasta", "Chef Luigi", 420);
        Video video3 = new Video("Top 10 Hiking Trails", "Nature Lover", 300);
        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Great explanation!"));
        video1.AddComment(new Comment("Charlie", "Can you do an advanced tutorial?"));

        // Add comments to video2
        video2.AddComment(new Comment("Daisy", "I love pasta!"));
        video2.AddComment(new Comment("Ethan", "Your cooking tips are amazing."));
        video2.AddComment(new Comment("Fiona", "This recipe was perfect."));

        // Add comments to video3
        video3.AddComment(new Comment("George", "Beautiful places!"));
        video3.AddComment(new Comment("Hannah", "Makes me want to go hiking now."));
        video3.AddComment(new Comment("Ian", "Which trail is your favorite?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayText());
            }
            Console.WriteLine();
        }
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video: {video.GetTitle()} by {video.GetAuthor()} has {video.GetNumberOfComments()} comments.");
        }

    }
}