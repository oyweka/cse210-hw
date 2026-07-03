using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter = "";
        string sign = "";

        if (gradePercentage < 0 || gradePercentage > 100)
        {
            Console.WriteLine("The value must be between 0 and 100.");
        }
        else
        {
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            if (gradePercentage % 10 >= 7 && letter != "A" && letter != "F")
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3 && letter != "F" && gradePercentage != 100)
            {
                sign = "-";
            }
            Console.WriteLine($"Your grade is: {letter}{sign}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed.");
            }
            else
            {
                Console.WriteLine("Wish you all the best next time.");
            }
        }
    }
}
