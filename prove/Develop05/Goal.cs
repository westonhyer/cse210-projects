using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;

    protected Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetStatus()
    {
        if (IsComplete())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual string GetDetails()
    {
        return $"{GetStatus()} {_goalName}";
    }
    
    public abstract string GetStringRepresentation();
}