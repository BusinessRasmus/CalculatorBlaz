namespace Shared;

public class CalculatorService
{
    public double AddNumbers(double a, double b)
    {
        var result = a + b;
        return result;
    }

    public double Subtract(double a, double b)
    {
        var result = a - b;
        return result;
    }

    public double Multiply(double a, double b)
    {
        var result = a * b;
        return result;
    }

    public double Divide(double a, double b)
    {
        var result = a / b;
        return result;
    }

}