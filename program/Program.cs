using System;
using System.Globalization;
using CalculatorApp;
using Tut2_s20123;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            if (args.Length != 3)
            {
                Console.Error.WriteLine("Usage: calculator <A> <B> op:+-*/");
                return;
            }

            if (!double.TryParse(args[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var a) ||
                !double.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var b))
            {
                Console.Error.WriteLine("Error: A and B must be numeric");
                return;
            }


            char op = args[2][0];

            try
            {
                var calc = new Calculator(a, b, op);
                var result = calc.Compute();


                Console.WriteLine(result.ToString(CultureInfo.InvariantCulture));
            }
            catch (DivideByZeroException)
            {
                Console.Error.WriteLine("Error: Division by zero.");
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
