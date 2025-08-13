using System;

namespace EternalQuest;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Goal '{_shortName}' already completed.");
            return 0;
        }

        _amountCompleted++;
        int basePts = int.TryParse(_points, out int pts) ? pts : 0;
        int earned = basePts + (_amountCompleted == _target ? _bonus : 0);

        Console.WriteLine($"Goal '{_shortName}' updated. Completed {_amountCompleted}/{_target}. +{earned} pts.");
        return earned;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
