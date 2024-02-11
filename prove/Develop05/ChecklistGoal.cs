using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for ChecklistGoal.");
    }

    public override bool IsComplete()
    {

        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"Details of ChecklistGoal: {_amountCompleted} out of {_target} completed";
    }

    public override string GetStringRepresentation()
    {
        return $"String representation of ChecklistGoal: {_shortName}";
    }
}
