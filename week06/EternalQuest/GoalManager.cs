using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    private int GetLevel() => 1 + (_score / 500); 


    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine()?.Trim() ?? "";

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. Level: {GetLevel()}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals yet."); return; }
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals yet."); return; }
        Console.WriteLine("Goal details:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine()?.Trim() ?? "";

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? "";
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? "";
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine() ?? "0";

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = ReadInt();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = ReadInt();
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals to record."); return; }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = ReadInt() - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine(earned > 0
            ? $"Congratulations! You earned {earned} points. Total Score: {_score}"
            : "No points earned (goal already complete or maxed).");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save to (e.g., goals.txt): ");
        string filename = Console.ReadLine() ?? "goals.txt";

        using var sw = new StreamWriter(filename);
        sw.WriteLine(_score);
        foreach (var g in _goals)
            sw.WriteLine(g.GetStringRepresentation());

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine() ?? "goals.txt";
        if (!File.Exists(filename)) { Console.WriteLine("File not found."); return; }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0) { Console.WriteLine("File is empty."); return; }

        _score = int.TryParse(lines[0], out int s) ? s : 0;
        var loaded = new List<Goal>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split('|');
            if (p.Length < 4) continue;

            string type = p[0];
            string name = p[1];
            string desc = p[2];
            string pts = p[3];

            switch (type)
            {
                case "Simple":
                    bool done = p.Length >= 5 && bool.Parse(p[4]);
                    loaded.Add(new SimpleGoal(name, desc, pts, done));
                    break;

                case "Eternal":
                    loaded.Add(new EternalGoal(name, desc, pts));
                    break;

                case "Checklist":
                    int amt = int.Parse(p[4]);
                    int tgt = int.Parse(p[5]);
                    int bonus = int.Parse(p[6]);
                    loaded.Add(new ChecklistGoal(name, desc, pts, tgt, bonus, amt));
                    break;
            }
        }

        _goals = loaded;
        Console.WriteLine("Goals loaded.");
    }

    private static int ReadInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int v)) return v;
            Console.Write("Please enter a valid integer: ");
        }
    }
    
    public void ListGoals()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals yet.");
        return;
    }

    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
    }
}

}
