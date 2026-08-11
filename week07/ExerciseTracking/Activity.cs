public abstract class Activity
{
    private DateTime _dateTime;
    private int _minutes;
    public Activity(DateTime dateTime, int minutes)
    {
        _dateTime = dateTime;
        _minutes = minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public DateTime GetDateTime()
    {
        return _dateTime;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public string GetSummary()
    {
        return $"{GetDateTime():dd MMM yyyy} {GetType().Name} ({GetMinutes()} min) - Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min per mile";
    }
}