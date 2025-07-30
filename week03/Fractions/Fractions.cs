
public class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
        
    }
    public Fractions(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public string GetfractionString()
    {
        string frac_string = $"{_numerator}/{_denominator}";
        return frac_string;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}