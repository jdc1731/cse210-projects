using System;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter the number of your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            var breathingActivity = new BreathingActivity(
                "Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                duration);
            breathingActivity.Run();
        }
        else if (choice == "2")
        {
            var reflectionActivity = new ReflectionActivity(
                "Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                duration);
            reflectionActivity.Run();
        }
        else if (choice == "3")
        {
            var listingPrompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            var listingActivity = new ListingActivity(
                "Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                duration,
                listingPrompts);
            listingActivity.Run();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
