public class Entry
{
   public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

} 