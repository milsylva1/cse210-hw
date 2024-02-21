using System;

public abstract class Activity
{
    protected DateTime Date { get; set; }
    protected int DurationMinutes { get; set; }

    public Activity(DateTime date, int durationMinutes)
    {
        Date = date;
        DurationMinutes = durationMinutes;
    }

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();

    public string GetSummary()
    {
        string distance = GetDistance();
        string speed = GetSpeed();
        string pace = GetPace();
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min) - Distance: {distance}, Speed: {speed}, Pace: {pace}";
    }
}
