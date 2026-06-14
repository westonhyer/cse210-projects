using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private int    _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void DisplayStartingMsg()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, do you want this session to last? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndMsg()
    {
        Console.WriteLine("Well done.");
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}.");
    }   

    public void ShowSpinner(int seconds)
    {
        string[] animation = {"|", "/", "-", "\\"};

        DateTime futureTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            foreach (string s in animation)
            {
                if (DateTime.Now >= futureTime) break;
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }     
    public void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}