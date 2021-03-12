using System;
using System.Threading;

namespace Task2
{
    class Calculator : ICalculator
    {
        Logger Logger { get; }

        public Calculator(Logger logger)
        {
            Logger = logger;
        }

        double ICalculator.Sum(double a, double b)
        {
            Logger.Event("Выполняется операция сложения . . .");
            Thread.Sleep(3000);
            return a + b;
        }

        double ICalculator.Subtraction(double a, double b)
        {
            Logger.Event("Выполняется операция вычитания . . .");
            Thread.Sleep(3000);
            return a - b;
        }

        double ICalculator.Multiplication(double a, double b)
        {
            Logger.Event("Выполняется операция умножения . . .");
            Thread.Sleep(3000);
            return a * b;
        }

        double ICalculator.Division(double a, double b)
        {
            Logger.Event("Выполняется операция деления . . .");
            Thread.Sleep(3000);
            return a / b;
        }

        void ICalculator.DisplayResult(double result)
        {
            Console.WriteLine("Результат: " + result);
        }

        double ICalculator.ReadNumber()
        {
            string read = Console.ReadLine();
            Logger.Event("Выполняется обработка данных . . .");
            Thread.Sleep(3000);
            return Convert.ToDouble(read);
        }
    }
}
