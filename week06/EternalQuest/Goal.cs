using System;

namespace EternalQuest;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;   

    public string Points => _points;
    public string GetName() => _shortName;

    protected Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();          
    public abstract string GetStringRepresentation();   // for save file
}

