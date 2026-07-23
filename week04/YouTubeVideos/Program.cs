using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Object Oriented Programming", "BYU-Idaho", 55);
        Comment commentAlex = new Comment("Alex", "Amazing video");
        Comment commentMike = new Comment("Mike", "I still do not understand this");
        Comment commentTony = new Comment("Tony", "I am loving programming");

        video1.AddComment(commentAlex);
        video1.AddComment(commentMike);
        video1.AddComment(commentTony);

        Video video2 = new Video("Introduction to C#", "BYU-Idaho", 50);
        Comment commentJohn = new Comment("John", "This has taught me a great!");
        Comment commentPeter = new Comment("Peter", "Now this is the way to learn");
        Comment commentSolo = new Comment("Solo", "Great insight");

        video2.AddComment(commentJohn);
        video2.AddComment(commentPeter);
        video2.AddComment(commentSolo);

        Video video3 = new Video("Encapsulation", "BYU-Idaho", 60);
        Comment commentJanet = new Comment("Janet", "Now I know how to use this principle!");
        Comment commentJoyce = new Comment("Joyce", "Wow, a great concept!");
        Comment commentMary = new Comment("Mary", "This adds to my abstraction knowledge");

        video3.AddComment(commentJanet);
        video3.AddComment(commentJoyce);
        video3.AddComment(commentMary);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()} - {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}