using Calculator.Lib;

namespace Calculator.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            var y = 10.0;
            var res = 0.0;
            
            res = Calc.Add(x, y);
            Console.WriteLine($"{x} + {y} = {res}");
            
            res = Calc.Sub(x, y);
            Console.WriteLine($"{x} - {y} = {res}");
            
            res = Calc.Mul(x, y);
            Console.WriteLine($"{x} * {y} = {res}");
            
            res = Calc.Div(x, y);
            Console.WriteLine($"{x} / {y} = {res}");

            try
            {
                res = Calc.Div(x, 0);
                Console.WriteLine($"{x} / {y} = {res}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR!!! Делить на ноль нельзя!");
            }
        }
    }
}