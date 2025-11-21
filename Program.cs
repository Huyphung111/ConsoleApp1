using System;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            int a = 9;
            int b = 10;

            int sum = Add(a, b);
            int difference = Subtract(a, b);
            int product = Multiply(a, b);
            double quotient = Divide(a, b);
            double square = Power(a, 2);

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {difference}");
            Console.WriteLine($"{a} * {b} = {product}");
            Console.WriteLine($"{a} / {b} = {quotient}");
            Console.WriteLine($"{a} ^ 2 = {square}");
        }

        private static int Add(int x, int y) => x + y;

        private static int Subtract(int x, int y) => x - y;

        private static int Multiply(int x, int y) => x * y;

        private static double Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return (double)x / y;
        }

        private static double Power(int x, int exponent)
        {
            return Math.Pow(x, exponent);
        }
    }
}
