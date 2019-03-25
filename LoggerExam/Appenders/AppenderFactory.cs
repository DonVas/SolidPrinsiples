using System;
using LoggerExam.Layouts;
using LoggerExam.Loggers;

namespace LoggerExam.Appenders
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeToLower = type.ToLower();

            switch (typeToLower)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout,new LogFile());
                    default:
                        throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
