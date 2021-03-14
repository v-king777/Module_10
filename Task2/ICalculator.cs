// <copyright file="ICalculator.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
namespace Task2
{
    /// <summary>
    /// Calculator interface
    /// </summary>
    internal interface ICalculator
    {
        /// <summary>
        /// Performs an addition operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of adding numbers a and b</returns>
        double Sum(double a, double b); // '+'

        /// <summary>
        /// Performs a subtraction operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of subtracting the numbers a and b</returns>
        double Subtraction(double a, double b); // '-'

        /// <summary>
        /// Performs a multiplication operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of the multiplication of numbers a and b</returns>
        double Multiplication(double a, double b); // '*'

        /// <summary>
        /// Performs division operation
        /// </summary>
        /// <param name="a">Variable one of type Double</param>
        /// <param name="b">Variable two of type Double</param>
        /// <returns>The result of dividing the numbers a and b</returns>
        double Division(double a, double b); // '/'

        /// <summary>
        /// Displays the result of an arithmetic operation
        /// </summary>
        /// <param name="result">The result of an arithmetic operation</param>
        void DisplayResult(double result); // '='

        /// <summary>
        /// Reads user input
        /// </summary>
        /// <returns>Variable of type Double</returns>
        double ReadNumber();
    }
}
