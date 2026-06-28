using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isCompleted = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isCompleted)
        {
            return 0;
        }

        _isCompleted = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{_goalName},{_description},{_points},{_isCompleted}";
        }
}