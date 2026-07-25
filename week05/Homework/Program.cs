using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Alex", "Division");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Alex", "Division", "23.2", "5-9");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Alex", "Reading", "Reading Skills");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}