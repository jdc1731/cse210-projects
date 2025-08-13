using System;
using System.Collections.Generic;

namespace ExerciseTracking;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        var activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0),   // distanceMiles
            new CyclingActivity(new DateTime(2022, 11, 3), 40, 18.0),  // speedMph
            new SwimmingActivity(new DateTime(2022, 11, 3), 25, 32)    // laps
        };
        
        foreach (var a in activities)
        Console.WriteLine(a.GetSummary());    
    }
}