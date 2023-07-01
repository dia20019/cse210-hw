class ReflectionActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Think of a time when you showed love.",
        "Think of a time when you acomplished something important.",
        "Think of a time when you overcame an obstacle.",
        "Think of a time when you magnified your talents."
    };
    private string[] _questions = new string[]
    {
        "Why was this experience meaningful?",
        "Which part of the experience you enjoyed most?",
        "What moved you to do this?",
        "How did you feel afterwards?",
        "Who shared this experience with you?",
        "Are there ways you can repeat this experience?",
        "What are your biggest takeaways from this event?",
        "Is there a lasting consecuence of this action?",
        "How can you use this memory to give you traction moving forward?"
    };
    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _activityDescription ="This will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public override void Start()
    {
        base.Start();

        Random random = new Random();
        int promptIndex = random.Next(_prompts.Length);
        string prompt = _prompts[promptIndex];

            Console.WriteLine("Consider this prompt \n");
            Console.WriteLine($"\t--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you have pondered it press enter.");
            Console.ReadKey();

            Console.WriteLine("Answer these questions for yourself.");
            Console.Write("You may begin in: ");
            Animation(ANIMATION_COUNTDOWN,3);
            Console.Clear();

            DateTime currentTime = DateTime.Now;
            DateTime futureTime = DateTime.Now.AddSeconds(_duration);

            do
            {
                int questionIndex = random.Next(_questions.Length);
                string question = _questions[questionIndex];

                Console.Write($"> {question} ");
                Animation(ANIMATION_SPINNER, 5);
                Console.WriteLine();

                currentTime = DateTime.Now;
            }
            while(currentTime < futureTime);
        base.End();
    }
}