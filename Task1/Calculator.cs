using System;

namespace Task1
{
    class Calculator : ICalculator
    {
        double ICalculator.Sum(double a, double b)
        {
            return a + b;
        }

        double ICalculator.Subtraction(double a, double b)
        {
            return a - b;
        }

        double ICalculator.Multiplication(double a, double b)
        {
            return a * b;
        }

        double ICalculator.Division(double a, double b)
        {
            return a / b;
        }

        void ICalculator.DisplayResult(double result)
        {
            Console.WriteLine("Результат: " + result);
        }

        double ICalculator.ReadNumber()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
