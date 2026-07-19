using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling("02 Nov 2026", 45.6, "Cycling", 20);
        Running running = new Running("03 Nov 2026", 30, "Running", 3.0);
        Swimming swimming = new Swimming("04 Nov 2026", 60, "Swimming", 35);

        List<Activity> activities = new List<Activity>();

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
        }
    }
}