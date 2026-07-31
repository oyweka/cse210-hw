// Added a summary that shows time spent in all mindfulness activities 
// and show total time when the user exits. 
using System;

class Program
{
    static void Main(string[] args)
    {
        string select = "";
        int totalTime = 0;

        while (select != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            select = Console.ReadLine();

            if (select == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                totalTime += breathing.GetDuration();
            }
            else if (select == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                totalTime += reflecting.GetDuration();
            }
            else if (select == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                totalTime += listing.GetDuration();
            }
            else if (select == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Activity Summary");
                Console.WriteLine($"Total mindfulness time: {totalTime} seconds");
                Console.WriteLine();
                Console.WriteLine("Thank you for participating in this activity!");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Your selection is not valid");
                Thread.Sleep(1000);
            }

        }
    }
}