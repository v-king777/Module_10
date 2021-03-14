// <copyright file="Logger.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
using System;

namespace Task2
{
    /// <summary>
    /// Logger class
    /// </summary>
    internal class Logger : ILogger
    {
        /// <summary>
        /// Creates an event message
        /// </summary>
        /// <param name="message">Event message</param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Creates an error message
        /// </summary>
        /// <param name="message">Error message</param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
