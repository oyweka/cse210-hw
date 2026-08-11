public class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime dateTime, int minutes, double speed) : base(dateTime, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed / 60) * GetMinutes();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}