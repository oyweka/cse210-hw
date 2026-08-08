using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid.");
                    break;
            }

            Console.WriteLine();
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine(GetLevel());
    }
    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("How many points are points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (type == "3")
        {
            Console.Write("What is the number of times this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus);

            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid goal.");
        }
    }
    private void RecordEvent()
    {
        ListGoalDetails();

        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[choice - 1];

        if (goal is SimpleGoal)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine("That goal has already been completed.");
                return;
            }

            goal.RecordEvent();
            _score += goal.GetPoints();

            Console.WriteLine(
                $"Congratulations! You earned {goal.GetPoints()} points.");
        }
        else if (goal is EternalGoal)
        {
            goal.RecordEvent();
            _score += goal.GetPoints();

            Console.WriteLine(
                $"You earned {goal.GetPoints()} points.");
        }
        else if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                Console.WriteLine("That goal has already been completed.");
                return;
            }

            checklist.RecordEvent();

            _score += checklist.GetPoints();

            Console.WriteLine(
                $"You earned {checklist.GetPoints()} points.");

            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();

                Console.WriteLine(
                    $"Congratulations! You earned a bonus of " +
                    $"{checklist.GetBonus()} points!");
            }
        }
    }
    private void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);

                SimpleGoal goal =
                    new SimpleGoal(name, description, points);

                if (complete)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal goal =
                    new EternalGoal(name, description, points);

                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal =
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
    private string GetLevel()
    {
        if (_score >= 1000)
        {
            return "Level 5 - Eternal Champion";
        }
        else if (_score >= 500)
        {
            return "Level 4 - Faithful";
        }
        else if (_score >= 250)
        {
            return "Level 3 - Disciple";
        }
        else if (_score >= 100)
        {
            return "Level 2 - Learner";
        }
        else
        {
            return "Level 1 - Beginner";
        }
    }
}