public class Fractions
{
    private int numerator;
    private int denominator;
    public Fractions()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fractions(int top)
    {
        numerator = top;
        denominator = 1;
    }
    public Fractions(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }
    public int GetNumerator()
    {
        return numerator;
    }
    public int GetDenominator()
    {
        return denominator;
    }
    public void SetNumerator(int top)
    {
        numerator = top;
    }
    public void SetDenominator(int bottom)
    {
        denominator = bottom;
    }
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}