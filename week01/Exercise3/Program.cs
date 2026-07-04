using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random number = new Random();
            int magicNumber = number.Next(1, 101);


            int guess;
            int guesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

            } while (guess != magicNumber);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"Total guesses: {guesses}");

            Console.Write("Do you want to continue? ");
            response = Console.ReadLine().ToLower();
        }

    }
}