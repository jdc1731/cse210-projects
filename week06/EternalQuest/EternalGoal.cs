using System;

namespace EternalQuest;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        int earned = int.TryParse(_points, out int pts) ? pts : 0;
        Console.WriteLine($"Recording event for eternal goal: {_shortName}. +{earned} points.");
        return earned;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
        => $"[∞] {_shortName} ({_description}) — {_points} pts each time";

    public override string GetStringRepresentation()
        => $"Eternal|{_shortName}|{_description}|{_points}";
}
