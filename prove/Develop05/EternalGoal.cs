using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Implementation of constructor
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for EternalGoal.");
    }

    public override bool IsComplete()
    {
        // Implementation of IsComplete method
        return false;
    }

    public override string GetDetailsString()
    {
        return "Details of EternalGoal";
    }

    public override string GetStringRepresentation()
    {
        return "String representation of EternalGoal";
    }
}
