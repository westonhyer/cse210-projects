using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Durint this activity, clear your mind and focus on your breathing.")
    {
    }
    
    public void Run()
    {
        DisplayStartingMsg();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            DisplayCountdown(4);

            Console.WriteLine("Breath out...");
            DisplayCountdown(6);

            Console.Clear();
        }
        
        DisplayEndMsg();
    }
}