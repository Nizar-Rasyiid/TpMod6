using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100 )
        {
            throw new ArgumentException("Title Tidak Boleh NULL dan Lebih dari 100 karakter");
        }
        Random random = new Random();
        id = random.Next(10000, 100000);
        this.title = title;
        playCount = 0;
    }


    public void IncreasePlayCount(int playCount)
    {
        if (playCount > 10000000)
        {
            throw new ArgumentOutOfRangeException("Pemanggilan Tidak Boleh Di atas 10.000.000");
        }
        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public void PrintVideoDetails()
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

        //Test Title
        try
        {
            SayaTubeVideo test1 = new SayaTubeVideo("In today's world, staying organized is crucial for productivity. Prioritize tasks, set goals, and use tools for efficiency. Mindfulness and breaks maintain focus. Balance work and life for well-being. Embrace strategies for confidences");
            test1.IncreasePlayCount(1);
            test1.PrintVideoDetails();
        }
        catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }
        //Test null
        try
        {
            SayaTubeVideo test2 = new SayaTubeVideo("");
            test2.IncreasePlayCount(1);
            test2.PrintVideoDetails();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //test overflow
        try
        {
            SayaTubeVideo tes3 = new SayaTubeVideo("Yang ini Tes Overflow");
            tes3.IncreasePlayCount(1000000000);
            tes3.PrintVideoDetails();
        }catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


        //Refer to Num3
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - NIZAR RASYIID");
            video.IncreasePlayCount(2000);
            video.PrintVideoDetails();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }
}
