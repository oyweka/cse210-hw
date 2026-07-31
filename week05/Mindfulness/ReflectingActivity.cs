public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity() : base("Reflecting Activity", "In this activity you will be able to demonstrate a time in your life where you showed resilience and strength. It will help you know how you can use this power in different aspects of your life.")
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);

        return _prompts[i];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(_questions.Count);

        return _questions[i];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine();

        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.WriteLine(GetRandomQuestion());

            ShowSpinner(5);

            Console.WriteLine();
        }
    }
    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}