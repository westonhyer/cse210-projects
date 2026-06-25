using System;

public class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _points;
    private bool _isComplete = false;

    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }
    public string GetDetails()
    {
        return $"[ ] {_goalName}\n{_goalDescription} - {_points} points.";
    }
    public string GetStatus()
    {
        return "";
    }