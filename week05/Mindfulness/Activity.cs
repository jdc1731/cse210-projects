using System;

namespace Mindfulness;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        ShowCountDown(3);
        

        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity.");
        Console.WriteLine($"You have earned {_duration} seconds of mindfulness.");
        ShowSpinner(2);
        Console.WriteLine("Thank you for participating!");
    }
        public void ShowSpinner(int seconds)
    { 
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");
    }
}
