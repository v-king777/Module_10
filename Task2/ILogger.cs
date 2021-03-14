// <copyright file="ILogger.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
namespace Task2
{
    /// <summary>
    /// Logger interface
    /// </summary>
    internal interface ILogger
    {
        /// <summary>
        /// Creates an event message
        /// </summary>
        /// <param name="message">Event message</param>
        void Event(string message);

        /// <summary>
        /// Creates an error message
        /// </summary>
        /// <param name="message">Error message</param>
        void Error(string message);
    }
}
