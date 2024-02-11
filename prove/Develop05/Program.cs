using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        goalManager.DisplayPlayerInfo();
        goalManager.ListGoalNames();
        goalManager.ListGoalDetails();
        goalManager.CreateGoal();
        goalManager.RecordEvent();
        goalManager.SaveGoals();
        goalManager.LoadGoals();
    }
}
