﻿namespace LoggerExam.Loggers
{
    public interface ILogFile
    {
        void Write(string message);
        int Size { get; set; }
    }
}