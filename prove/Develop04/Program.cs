using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int choice = -1;
        do
        {   
            ShowMenu();
            Console.Write("Please Type The Number for the Activity you Want Now: ");
            choice = int.Parse(Console.ReadLine());

            Activity activity;
            switch(choice) 
            {
                case 1:
                    activity = new BreathingActivity();
                    activity.Start();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    activity.Start();
                    break;
                case 3:
                    activity = new ListingActivity();
                    activity.Start();
                    break;
                case 0:
                    // display good bye message
                    DisplayEndMessage();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select among these options");
                    break;
            }
        }while (choice != 0);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome back to your Mindfulness Activities");
    }
    static void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine("See you soon");
    }
    static void ShowMenu()
    {
        Console.Clear();
        Console.Write("""
            Would you like to:

            1) Start Breathing Activity
            2) Start Reflection Activity
            3) Start Listing Activity
            0) Exit

            """);
    }
}