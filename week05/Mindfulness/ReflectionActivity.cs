using System;
using System.Collections.Generic;

namespace Mindfulness
{
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

            ShowSpinner(3);

            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds < _duration)
    {
            // Pick a random question each time
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);

            // Pause to reflect
            ShowSpinner(4);
    }

            DisplayEndingMessage();
        }
    }
}

