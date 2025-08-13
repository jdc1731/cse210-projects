using System;

namespace ExerciseTracking;

public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;
    protected double _distance;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        _distance = GetDistance();
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = GetType().Name.Replace("Activity", "");
        return $"{_date:dd MMM yyyy} {activityType} ({_minutes} min): Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}
