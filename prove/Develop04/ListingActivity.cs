class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Who do you consider family?.",
        "What are your talents?.",
        "What good have you done in the world today?.",
        "Which ones were your most enjoyable moments recently?.",
        "When did you feel the Holy Ghost?."
    };
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public override void Start()
    {
        base.Start();

            Random random = new Random();

            int index = random.Next(_prompts.Length);
            string prompt = _prompts[index];

            List<string> answers = new List<string>();

            Console.WriteLine("list every response you can for this prompt");
            Console.WriteLine($"\t---{prompt}---");
            Console.Write("You may begin in: ");
            Animation(ANIMATION_COUNTDOWN,3);
            Console.WriteLine();

            DateTime currentTime = DateTime.Now;
            DateTime futureTime = DateTime.Now.AddSeconds(_duration);
            
            do
            {
                Console.Write("> ");
                answers.Add(Console.ReadLine());
                Console.WriteLine();
                currentTime = DateTime.Now;
            }while(currentTime < futureTime);

            Console.WriteLine($"You listed {answers.Count()} items");

        base.End();
    }
}