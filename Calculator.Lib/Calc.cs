namespace Calculator.Lib;

public static class Calc
{
    public static double Add(double x, double y) => x + y;
    public static double Sub(double x, double y) => x - y;
    public static double Mul(double x, double y) => x * y;

    public static double Div(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException(nameof(y));
        }

        return x / y;
    }
}