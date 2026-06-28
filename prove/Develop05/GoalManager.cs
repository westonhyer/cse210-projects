using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public int Score => _score;
    public IReadOnlyList<Goal> Goals => _goals;
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public bool RecordEvent(int displayIndex)
    {
        int index = displayIndex - 1;
        if (index < 0 || index >= _goals.Count)
        {
            return false;
        }
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        if (pointsEarned > 0)
        {
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("That goal is already complete -- no points earned.");
        }

        return true;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You haven't created any goals yet.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Saved to {filename}.");
    }
    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Could not find file '{filename}'.");
            return;
        }
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] typeSplit = lines[i].Split(':');
            string type = typeSplit[0];
            string[] details = typeSplit[1].Split(',');
            _goals.Add(CreateGoal(type, details));
        }
        Console.WriteLine($"Loaded from {filename}.");
    }
    private Goal CreateGoal(string type, string[] details)
    {
        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(
                    details[0],              
                    details[1],                
                    int.Parse(details[2]),     
                    bool.Parse(details[3]));    
            case "EternalGoal":
                return new EternalGoal(
                    details[0],                
                    details[1],                
                    int.Parse(details[2]));     
            case "ChecklistGoal":
                return new ChecklistGoal(
                    details[0],                
                    details[1],                 
                    int.Parse(details[2]),      
                    int.Parse(details[3]),      
                    int.Parse(details[4]),       
                    int.Parse(details[5]));     
            default:
                throw new InvalidDataException($"Unknown goal type '{type}' in save file.");
        }
    }
}