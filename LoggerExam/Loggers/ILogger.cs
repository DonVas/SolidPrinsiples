namespace LoggerExam.Loggers
{
    public interface ILogger
    {
        void Error(string dateTime, string errorMessage);
        void Info(string dateTime, string infoMessage);
    }
}