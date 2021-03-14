// <copyright file="MyException.cs" company="MyCompany.com">
// Copyright (c) 2021. All rights reserved.
// </copyright>
// <author>v-king777</author>
using System;

namespace Task2
{
    /// <summary>
    /// MyException class
    /// </summary>
    internal class MyException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyException"/> class
        /// </summary>
        /// <param name="message">Exception message</param>
        public MyException(string message) : base(message)
        {
        }
    }
}
