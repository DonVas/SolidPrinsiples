using System;
using System.Collections.Generic;
using System.Text;
using LoggerExam.Appenders;

namespace LoggerExam.Loggers
{
    public class Logger : ILogger
    {
        private IAppender appender;
        private IAppender fileAppender;

        public Logger(IAppender appender, IAppender fileAppender)
        {
            this.appender = appender;
            this.fileAppender = fileAppender;
        }
        public void Error(string dateTime, string errorMessage)
        {
            appender.Append(dateTime,"Error",errorMessage);
            fileAppender.Append(dateTime, "Error", errorMessage);
        }

        public void Info(string dateTime, string infoMessage)
        {
           appender.Append(dateTime,"Info",infoMessage);
           fileAppender.Append(dateTime, "Info", infoMessage);
        }
    }
}
