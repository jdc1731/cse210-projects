using System;

namespace ExerciseTracking;

public class RunningActivity : Activity
{
    private double _distanceMiles;
       public RunningActivity(DateTime date, int minutes, double distanceMiles)
        : base(date, minutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed()
        => (GetDistance() / GetMinutes()) * 60.0; // mph

    public override double GetPace()
        => GetMinutes() / GetDistance(); // min per mile
}