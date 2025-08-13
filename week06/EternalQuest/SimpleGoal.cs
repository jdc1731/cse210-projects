using System;

namespace EternalQuest;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete) return 0;
        _isComplete = true;

        int earned = int.TryParse(_points, out int pts) ? pts : 0;
        Console.WriteLine($"Event recorded for goal: {_shortName}. You earned {earned} points!");
        return earned;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        string box = _isComplete ? "[X]" : "[ ]";
        return $"{box} {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        // Type|Name|Description|Points|IsComplete
        return $"Simple|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}

