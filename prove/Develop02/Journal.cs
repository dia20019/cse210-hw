using System;

namespace classes{
    public class Journal
    {
        IDictionary<string, bool> prompts = new Dictionary<string, bool>();
        public void AddKeyValuePair()
        {
            prompts.Add("What was the best part of the day?", false);
            prompts.Add("Did anything go wrong?", false);
            prompts.Add("Who did you interact with?", false);
            prompts.Add("How is your family?", false);
            prompts.Add("Any spiritual experience or prompting?", false);
        }
        public List<string> responses = new List<string>();
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Please select 1 of the following options:");
            Console.WriteLine("1. Get a promt to write a new entry");
            Console.WriteLine("2. Display today's journal entry");
            Console.WriteLine("3. Save this entry");
            Console.WriteLine("4. Load a past entry");
            Console.WriteLine("5. Exit this program");
            Console.WriteLine("What would you like to do now?");
        }
        public void DisplayEntry()
        {
            responses.ForEach(Console.WriteLine);
        }
        public void Write()
        {
            List<string> keys = new List<string>(prompts.Keys);
            List<string> unansweredQuestion = new List<string>(keys.Where(question => this.prompts[question] == false));
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            Random randomNumber = new Random();
            int listSize = unansweredQuestion.Count;
            int randomIndex = randomNumber.Next(0, listSize);
            if (unansweredQuestion.Count == 0)
            {
                Console.WriteLine("No more prompts available");
                return;
            }
            string index  = randomIndex.ToString();
            string randomQuestion = (unansweredQuestion[randomIndex]);
            
            prompts[randomQuestion] = true;
            Console.WriteLine(randomQuestion);
            

            string answer = Console.ReadLine();
            responses.Add($"Date: {date} - Prompt: {randomQuestion} - {answer}");
        }
        public Journal()
        {

        }
    }
}