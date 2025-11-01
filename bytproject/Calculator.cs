namespace Tut2_s20123
{
    public sealed class Calculator
    {
        public double A { get; }
        public double B { get; }
        public char Operator { get; }

        public Calculator(double a, double b, char op)
        {
            A = a;
            B = b;
            Operator = op;
        }
        
        public double Compute()
        {
            switch (Operator)
            {
                case '+': return A + B;
                case '-': return A - B;
                case '*': return A * B;
                case '/':
                    if (B == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return A / B;
                default:
                    throw new ArgumentException(
                        $"Unsupported operator '{Operator}'. Use one of: +, -, *, /.",
                        nameof(Operator)
                    );
            }
        }
        
        public static double Compute(double a, double b, char op) => new Calculator(a, b, op).Compute();
    }
}