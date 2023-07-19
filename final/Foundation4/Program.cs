using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(40,"14 Jul", 30);
        activities.Add(running);

        SwimmingActivity swimming = new SwimmingActivity(150,"30 Jun", 30);
        activities.Add(swimming);

        CyclingActivity cycling = new CyclingActivity(60,"15 Jun", 30);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            System.Console.WriteLine(activity.GetSummary());
        }
    }
}