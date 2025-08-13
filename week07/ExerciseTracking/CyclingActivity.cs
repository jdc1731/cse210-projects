using System;

namespace ExerciseTracking;

public class CyclingActivity : Activity
{
    // Cycling stores SPEED (mph), not distance
    private double _speedMph;

    public CyclingActivity(DateTime date, int minutes, double speedMph)
        : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed() => _speedMph; // mph

    public override double GetDistance()
        => (_speedMph * GetMinutes()) / 60.0; // miles

    public override double GetPace()
        => 60.0 / _speedMph; // min per mile
}

