// Creativity feature
// Added best moments to allow users to save one of the best moment for the day.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Pick option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");

                Console.Write("Today's best moment: ");
                newEntry._bestMoment = Console.ReadLine();

                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {newEntry._promptText}");

                Console.Write("Response: ");
                newEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.SaveToFile();
            }
            else if (choice == "4")
            {
                myJournal.LoadFromFile();
            }
            else if (choice == "5")
            {
                isRunning = false;
            }
        }
    }
}