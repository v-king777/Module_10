﻿namespace Interfaces
{
    public interface ILogger
    {
        void Event(string message);

        void Error(string message);
    }
}
