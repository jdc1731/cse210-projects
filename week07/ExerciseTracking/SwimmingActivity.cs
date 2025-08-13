using System;

namespace ExerciseTracking;

public class SwimmingActivity : Activity
{
    private double _paceMinutesPerMile;
    
    public SwimmingActivity(DateTime date, int minutes, double paceMinutesPerMile)
        : base(date, minutes)
    {
        _paceMinutesPerMile = paceMinutesPerMile;
    }
}
