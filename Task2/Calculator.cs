// <copyright file="Calculator.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
using System;
using System.Threading;

namespace Task2
{
    /// <summary>
    /// Calculator class
    /// </summary>
    internal class Calculator : ICalculator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calculator"/> class
        /// </summary>
        /// <param name="logger">Variable of type Logger</param>
        public Calculator(Logger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Gets a variable of type Logger
        /// </summary>
        private Logger Logger { get; }

        /// <summary>
        /// Performs an addition operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of adding numbers a and b</returns>
        double ICalculator.Sum(double a, double b)
        {
            Logger.Event("Выполняется операция сложения . . .");
            Thread.Sleep(2000);
            return a + b;
        }

        /// <summary>
        /// Performs a subtraction operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of subtracting the numbers a and b</returns>
        double ICalculator.Subtraction(double a, double b)
        {
            Logger.Event("Выполняется операция вычитания . . .");
            Thread.Sleep(2000);
            return a - b;
        }

        /// <summary>
        /// Performs a multiplication operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of the multiplication of numbers a and b</returns>
        double ICalculator.Multiplication(double a, double b)
        {
            Logger.Event("Выполняется операция умножения . . .");
            Thread.Sleep(2000);
            return a * b;
        }

        /// <summary>
        /// Performs division operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of dividing the numbers a and b</returns>
        double ICalculator.Division(double a, double b)
        {
            Logger.Event("Выполняется операция деления . . .");
            Thread.Sleep(2000);
            return a / b;
        }

        /// <summary>
        /// Displays the result of an arithmetic operation
        /// </summary>
        /// <param name="result">The result of an arithmetic operation</param>
        void ICalculator.DisplayResult(double result)
        {
            Console.WriteLine("Результат: " + result);
        }

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <returns>Variable of type Double</returns>
        double ICalculator.ReadNumber()
        {
            string read = Console.ReadLine();
            Logger.Event("Выполняется обработка данных . . .");
            Thread.Sleep(2000);
            return Convert.ToDouble(read);
        }
    }
}
