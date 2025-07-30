//For full credit I use a JSON file to save the entries to.
using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            // Process the user's choice
            if (choice == "1")
            {
                Console.WriteLine("Writing a new entry...");
                Entry entry = new Entry();
                entry.Date = DateTime.Now.ToString("yyyy-MM-dd");
                entry.Prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.Write("Your response: ");
                entry.Response = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Displaying all entries:");
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}