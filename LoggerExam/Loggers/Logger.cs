using LoggerExam.Appenders;
using LoggerExam.Loggers.Enums;

namespace LoggerExam.Loggers
{
    public class Logger : ILogger
    {
        private IAppender appender;
        private IAppender fileAppender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }
        public Logger(IAppender appender, IAppender fileAppender)
        :this(appender)
        {
            this.fileAppender = fileAppender;
        }

        public void Info(string dateTime, string infoMessage)
        {
            this.Append(dateTime, (ReportLevel)1, infoMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            this.Append(dateTime, (ReportLevel)2, warningMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.Append(dateTime, (ReportLevel)3, errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            this.Append(dateTime, (ReportLevel)4, criticalMessage);
        }

       public  void Fatal(string dateTime, string fatalMessage)
        {
            this.Append(dateTime, (ReportLevel)5, fatalMessage);
        }
            

        private void Append(string dateTime, ReportLevel type, string message)
        {
            appender?.Append(dateTime, type, message);
            fileAppender?.Append(dateTime, type, message);
        }
    }
}
