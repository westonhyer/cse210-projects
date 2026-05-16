using System;

public class Entry
{
    public string _date;
    public string _promptTxt;
    public string _entryTxt;
    public List<string> _prompts = new List<string>{
        "What was the best part of your day?",
        "When did you feel most happy today?",
        "What did you do to be better than yesterday?",
        "What happened at work today?",
        "What has been your primary focus recently?",
        "What is something you noticed today that you normally overlook?",
        "What did you do to show your wife you love her today?",
        "What did you do to lift someone else today?",
        "What excuses have you been making up recently?",
        "What am I avoiding right now and why?"
    };

    public int RandomNumberGenerator()
    {
        return Random.Shared.Next(0, _prompts.Count);
    }
    public void DisplayEntryPrompt()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        
        int promptIndex = RandomNumberGenerator();
        _promptTxt = _prompts[promptIndex];
        
        Console.WriteLine($"\n{_date}");
        Console.WriteLine($"{_promptTxt}");
        Console.Write("> ");

        _entryTxt = Console.ReadLine();

    }

    public void DisplayEntries()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_promptTxt}");
        Console.WriteLine($"Entry: {_entryTxt}");
    }
}