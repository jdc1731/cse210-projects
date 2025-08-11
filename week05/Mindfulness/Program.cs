//I added a counter that keeps track of how many times each activity is completed.
//I also added a summary at the end of the program that displays how many times each activity

using System;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Project!");

        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the number of your choice: ");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                keepRunning = false;
                continue;
            }

            Console.Write("Enter duration in seconds: ");
            string durationInput = Console.ReadLine();
            int duration;
            bool validDuration = int.TryParse(durationInput, out duration);

            if (!validDuration || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive number.");
                continue;  // Restart the loop if duration invalid
            }

            if (choice == "1")
            {
                var breathingActivity = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    duration);
                breathingActivity.Run();
                breathingCount++; // Increment count here
            }
            else if (choice == "2")
            {
                var reflectionActivity = new ReflectionActivity(
                    "Reflection Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    duration);
                reflectionActivity.Run();
                reflectionCount++;
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
                listingCount++;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        Console.WriteLine("Goodbye! Thanks for practicing mindfulness.");
        Console.WriteLine("Session Summary:");
        Console.WriteLine($"Breathing activities completed: {breathingCount}");
        Console.WriteLine($"Reflection activities completed: {reflectionCount}");
        Console.WriteLine($"Listing activities completed: {listingCount}");
    }
}


