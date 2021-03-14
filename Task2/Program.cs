// <copyright file="Program.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
using System;
using System.Threading;

namespace Task2
{
    /// <summary>
    /// Program class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Gets or sets a variable of type Logger
        /// </summary>
        private static Logger Logger { get; set; }

        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">Array of variables of type String</param>
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=== Примитивный и ооочень медленный калькулятор ===\n");

            while (true)
            {
                double result;
                Logger = new Logger();
                ICalculator calculator = new Calculator(Logger);

                try
                {
                    Console.Write("Введите первое число: ");
                    double a = calculator.ReadNumber();

                    Console.Write("Введите второе число: ");
                    double b = calculator.ReadNumber();

                    Console.Write("Выберите операцию '+', '-', '*', '/': ");
                    string operation = Console.ReadLine();

                    Logger.Event("Выполняется обработка данных . . .");
                    Thread.Sleep(2000);

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
                                throw new DivideByZeroException();
                            }
                            else
                            {
                                result = calculator.Division(a, b);
                            }

                            break;

                        default:
                            throw new MyException("Неизвестная операция!");
                    }

                    calculator.DisplayResult(result);
                }
                catch (FormatException formatEx)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(2000);
                    Logger.Error("Некорректный ввод числа!");
                    Logger.Error(formatEx.Message);
                }
                catch (OverflowException overflowEx)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(2000);
                    Logger.Error("Число слишком большое!");
                    Logger.Error(overflowEx.Message);
                }
                catch (DivideByZeroException divEx)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(2000);
                    Logger.Error("Деление на ноль невозможно!");
                    Logger.Error(divEx.Message);
                }
                catch (MyException myEx)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(2000);
                    Logger.Error(myEx.Message);
                }
                catch (Exception ex)
                {
                    Logger.Error("Что-то пошло не так . . .");
                    Thread.Sleep(2000);
                    Logger.Error("Произошла ошибка: " + ex.Message);
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
