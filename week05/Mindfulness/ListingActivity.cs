using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mindfulness;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, int duration, List<string> prompts)
        : base(activityName, description, duration)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("You will have a few seconds to think about this prompt.");
        ShowCountDown(5);

        Console.WriteLine("Start listing items. Press Enter after each item:");

        int count = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    count++;
                }
            }
            else
            {
                System.Threading.Thread.Sleep(100);
            }
        }

        stopwatch.Stop();

        Console.WriteLine($"You listed {count} items.");
        DisplayEndingMessage();
    }
}
