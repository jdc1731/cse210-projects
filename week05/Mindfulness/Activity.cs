using System;

namespace Mindfulness;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string workdescription, int duration)
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
    string[] spinnerChars = { "|", "/", "-", "\\" };
    Console.Write(" "); 

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int spinnerIndex = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write(spinnerChars[spinnerIndex]);
        Thread.Sleep(250); 

        Console.Write("\b \b");

        spinnerIndex = (spinnerIndex + 1) % spinnerChars.Length;
    }
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
