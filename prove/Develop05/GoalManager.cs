using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Goal manager started.");
    }

    public void DisplayPlayerInfo()
    {
        // Implementation of DisplayPlayerInfo method
        Console.WriteLine($"Player's score: {_score}");
    }

    public void ListGoalNames()
    {
        // Implementation of ListGoalNames method
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal. _shortName);
        }
    }

    public void ListGoalDetails()
    {
        // Implementation of ListGoalDetails method
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        // Implementation of CreateGoal method
        _goals.Add(new SimpleGoal("New Goal", "Description", 10));
    }

    public void RecordEvent()
    {
        // Implementation of RecordEvent method
        foreach (var goal in _goals)
        {
            goal.RecordEvent();
        }
    }

    public void SaveGoals()
    {
        // Implementation of SaveGoals method
        // Write code here to save goals to a file or database
    }

    public void LoadGoals()
    {
        // Implementation of LoadGoals method
        // Write code here to load goals from a file or database
    }
}
