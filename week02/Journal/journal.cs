using System.Text.Json;
using System.IO;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        string jsonString = JsonSerializer.Serialize(_entries);
        File.WriteAllText(filename, jsonString);

    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}