using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _bestMoment;
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Best moment: {_bestMoment}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response:{_entryText}");
    }
}