using LoggerExam.Loggers.Enums;

namespace LoggerExam.Appenders
{
    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);
        ReportLevel ReportLevel { get; set; }
    }
}