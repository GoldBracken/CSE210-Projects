public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction ()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction (int wholeNum)
    {
        _numerator = wholeNum;
        _denominator = 1;
    }

    public Fraction (int numerator, int denominator)
    {
        _numerator = numerator;
        SetDenominator(denominator);
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            _denominator = denominator;
        }
        else
        {
            _denominator = 1;
        }
    }

    public string GetFractionString()
    {
        return $"{_numerator} / {_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }

    public override string ToString()
    {
        return $"{_numerator} / {_denominator}";
    }
}