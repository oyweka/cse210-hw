public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }
    public int GetTop()
    {
        return _numerator;
    }
    public int GetBottom()
    {
        return _denominator;
    }
    public void SetTop(int top)
    {
        _numerator = top;
    }
    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }
    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}