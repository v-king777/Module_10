using System;

namespace Task2
{
    class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
