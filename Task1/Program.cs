using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            try
            {
                double result = 0;
                double a = calculator.ReadNumber();
                double b = calculator.ReadNumber();
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = calculator.Sum(a, b);
                        break;

                    case "-":
                        result = calculator.Subtraction(a, b);
                        break;

                    case "*":
                        result = calculator.Multiplication(a, b);
                        break;

                    case "/":
                        result = calculator.Division(a, b);
                        break;

                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }

                calculator.DisplayResult(result);
            }

            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод числа");
            }
        }
    }
}
