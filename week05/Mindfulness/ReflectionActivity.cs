using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mindfulness;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you felt proud of yourself.",
            "Reflect on a challenge you overcame.",
            "Consider a moment that made you feel grateful.",
            "Recall a time when you learned something new."
        };

        _questions = new List<string>
        {
            "What did you learn from this experience?",
            "How did it change your perspective?",
            "What would you do differently next time?",
            "How can you apply this lesson in the future?",
            "What emotions did you experience during this time?",
            "How did this experience shape who you are today?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("Take a moment to reflect on the prompt.");
        ShowSpinner(5);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4);

            
            if (stopwatch.Elapsed.TotalSeconds >= _duration)
                break;
        }

        stopwatch.Stop();

        DisplayEndingMessage();
    }
}

