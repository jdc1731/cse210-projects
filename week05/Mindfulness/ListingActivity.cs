using System;

namespace Mindfulness;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, int duration, List<string> prompts)
    : base(activityName, description, duration)
    {
        _prompts = prompts;
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("You have 5 seconds to think about your response.");
        ShowCountDown(5);

        Console.WriteLine("Start listing items. Press Enter after each item:");

        DateTime startTime = DateTime.Now;
        _count = 0;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
    {
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            _count++;
        }
    }

        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
}