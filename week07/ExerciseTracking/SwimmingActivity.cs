using System;

namespace ExerciseTracking;

public class SwimmingActivity : Activity
{
    private int _laps; // 50 m per lap

    public SwimmingActivity(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
        => _laps * 50.0 / 1000.0 * 0.62; // miles

    public override double GetSpeed()
        => (GetDistance() / GetMinutes()) * 60.0; // mph

    public override double GetPace()
        => GetMinutes() / GetDistance(); // min per mile
}

