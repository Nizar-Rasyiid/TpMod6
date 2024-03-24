using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    { set; get; }
    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = 0;
    }

    public increasePlayCount(int playCount)
    {
        playCount++;
    }

    public PrintVideoDetails()
    {
        Console.WriteLine("Video Details:");
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - NIZAR RASYIID");
        video.increasePlayCount(10);
        video.PrintVideoDetails();
    }
}
