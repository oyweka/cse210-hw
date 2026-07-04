using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;
        int largest = numbers[0];
        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }

            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }

        }
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("No positive number entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}