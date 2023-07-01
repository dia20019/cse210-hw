class Activity
{
    protected const string ANIMATION_SPINNER = "spinner";
    protected const string ANIMATION_COUNTDOWN = "countdown";
    protected const string ANIMATION_PAUSE = "pause";
    protected string _activityName;
    protected string _activityDescription;
    public int _duration;
    public Activity()
    {
        _activityName = "Activity";
        _activityDescription = "This will help you be more mindful";
    }
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How many seconds will you dedicate for this activity?: ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation(ANIMATION_SPINNER);
    }
    public virtual void End()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done");
        Animation(ANIMATION_SPINNER);
        Console.WriteLine($"You have completed {_duration} more seconds of this {_activityName} ");
        Animation(ANIMATION_SPINNER);
    }
    protected void Animation(string type, int time = 3)
    {
        if (type == ANIMATION_PAUSE)
        {
            Console.Write("Pause");
            for (int i = 0; i < time; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
        else if (type == ANIMATION_COUNTDOWN)
        {
            for (int i = time; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        else if(type == ANIMATION_SPINNER )
        {
            DateTime futureTime = DateTime.Now.AddSeconds(time);
            DateTime currentTime = DateTime.Now;
            
            string spin = "|/-\\";
            
            do
            {
                foreach (char item in spin)
                {
                    Console.Write($"{item}");
                    Thread.Sleep(400);
                    Console.Write("\b \b");
                }
                currentTime = DateTime.Now;
            }
            while(currentTime < futureTime);
            Console.WriteLine();
        }
    }
}