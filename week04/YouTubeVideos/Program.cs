using System;
using System.Collections.Generic;
Console.WriteLine(">>> RUNNING MY YOUTUBE APP <<<");

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"  - {comment}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Learn C# Basics", "Alice", 600);
        Video video2 = new Video("Object-Oriented Programming in C#", "Bob", 900);
        Video video3 = new Video("Top 10 Coding Tips", "Charlie", 750);
        Video video4 = new Video("Mastering LINQ", "Diana", 850);

        // Add comments to video1
        video1.AddComment(new Comment("John", "This was super helpful!"));
        video1.AddComment(new Comment("Maria", "Thanks for the clear explanation."));
        video1.AddComment(new Comment("Eve", "I finally understand classes!"));

        // Add comments to video2
        video2.AddComment(new Comment("Sam", "OOP is clearer now."));
        video2.AddComment(new Comment("Diana", "I like the examples."));
        video2.AddComment(new Comment("Victor", "Well explained, thank you!"));

        // Add comments to video3
        video3.AddComment(new Comment("Leo", "Tip #3 saved me so much time!"));
        video3.AddComment(new Comment("Karen", "This was fun to watch."));
        video3.AddComment(new Comment("Mike", "I’ll share this with my friends."));

        // Add comments to video4
        video4.AddComment(new Comment("Sophia", "LINQ makes coding so much easier."));
        video4.AddComment(new Comment("Chris", "Clear and concise tutorial!"));
        video4.AddComment(new Comment("Nina", "Exactly what I needed for my project."));

        // Store all videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all video info
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
