using System;

namespace Mindfulness;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        int totalBreaths = _duration / 4; 
        for (int i = 0; i<totalBreaths; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000); 
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000); 
        }

        DisplayEndingMessage();
    
    }

}
