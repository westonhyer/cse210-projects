using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntries();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptTxt}|{entry._entryTxt}");
            }
        }
    }

    public void Load(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptTxt = parts[1];
            entry._entryTxt = parts[2];

            _entries.Add(entry);
        }
    }
    
    public void CheckReminder()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You don't have any entries yet.");
            Console.WriteLine("Take a few minutes to write about your day!");
            return;
        }

        Entry lastEntry = _entries[_entries.Count - 1];

        DateTime lastDate = DateTime.Parse(lastEntry._date);

        TimeSpan difference = DateTime.Now - lastDate;

        int days = difference.Days;

        if (days >= 1)
        {
            Console.WriteLine($"\nIt has been {days} day(s) since your last journal entry.");
            Console.WriteLine("Would you like to write an entry today?");
        }
        else
        {
            Console.WriteLine("\nGreat job staying consistent with your journal!");
        }
    }
}