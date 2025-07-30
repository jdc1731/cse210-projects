using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        List<Scripture> scriptures = new List<Scripture>();

        foreach (string line in File.ReadAllLines("scriptures.txt"))
        {
            string[] parts = line.Split('|');

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);

            Reference reference;
            string text;

            if (parts.Length == 5)
            {
                int endVerse = int.Parse(parts[3]);
                text = parts[4];
                reference = new Reference(book, chapter, verse, endVerse);
            }
            else
            {
                text = parts[3];
                reference = new Reference(book, chapter, verse);
            }

            Scripture scripture = new Scripture(reference, text);
            scriptures.Add(scripture);
        }
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
        
        bool quit = false;

        while (!quit && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                quit = true;
                break;
            }

            selectedScripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            if (!quit)
            {
                Console.WriteLine("\nAll words are hidden. Good job!");
            }
            else
            {
                Console.WriteLine("\nYou chose to quit. Goodbye!");
            }
        }

    }
}