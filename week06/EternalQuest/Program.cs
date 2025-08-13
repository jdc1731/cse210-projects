// I added a leveling system. The player gains points for completing goals, and their level increases every 500 points. The current level is displayed in the player info.

using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        new GoalManager().Start();
    }
}