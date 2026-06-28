using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int timesCompleted = 0) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _timesCompleted++;
        int pointsEarned = _points;

        if (_timesCompleted == _target)
        {
            pointsEarned += _bonus;
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }

    public override string GetDetails()
    {
        return $"{GetStatus()} - {_goalName}\n{_description}\nCompleted {_timesCompleted}/{_target} times.";
    }

    public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{_goalName},{_description},{_points},{_target},{_bonus},{_timesCompleted}";
        }
}