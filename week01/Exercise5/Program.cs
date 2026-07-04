using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"Hi {userName}, the square of your number is: {squaredNumber}");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }
}