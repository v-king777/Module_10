using System;
using System.Threading;

namespace Task2
{
    class Program
    {
        static Logger Logger { get; set; }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=== Примитивный и ооочень медленный калькулятор ===\n");

            while (true)
            {
                try
                {
                    double result = 0;
                    
                    Logger = new Logger();

                    ICalculator calculator = new Calculator(Logger);

                    Console.Write("Введите первое число: ");
                    double a = calculator.ReadNumber();

                    Console.Write("Введите второе число: ");
                    double b = calculator.ReadNumber();

                    Console.Write("Выберите операцию '+', '-', '*', '/': ");
                    string operation = Console.ReadLine();
                    
                    Logger.Event("Выполняется обработка данных . . .");
                    Thread.Sleep(3000);

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
                            if (b == 0)
                            {
                                Logger.Error("Что-то пошло не так . . .");
                                Thread.Sleep(3000);
                                Console.WriteLine("Деление на ноль невозможно!");
                            }
                            else
                            {
                                result = calculator.Division(a, b);
                            }
                            break;

                        default:
                            Logger.Error("Что-то пошло не так . . .");
                            Thread.Sleep(3000);
                            Console.WriteLine("Неизвестная операция!");
                            break;
                    }

                    calculator.DisplayResult(result);
                }

                catch (FormatException)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(3000);
                    Console.WriteLine("Некорректный ввод числа!");
                }

                catch (OverflowException)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(3000);
                    Console.WriteLine("Число слишком большое!");
                }

                catch (Exception ex)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(3000);
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                finally
                {
                    Console.WriteLine("\nНажмите <Esc> для выхода или любую клавишу для продолжения . . .\n");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
