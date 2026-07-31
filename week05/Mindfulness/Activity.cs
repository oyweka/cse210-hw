public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome To The {_name}");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Get ready ...");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string animation in spinner)
            {
                Console.Write(animation);
                Thread.Sleep(250);
                Console.Write("\b\b \b\b");

                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("You did a great job!");
        ShowSpinner(4);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);

        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
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