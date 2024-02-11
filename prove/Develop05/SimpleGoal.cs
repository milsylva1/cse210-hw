using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for SimpleGoal.");
    }

    public override bool IsComplete()
    {
        // Implementation of IsComplete method
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        // Implementation of GetDetailsString method
        return "Details of SimpleGoal";
    }

    public override string GetStringRepresentation()
    {
        // Implementation of GetStringRepresentation method
        return "String representation of SimpleGoal";
    }
}
