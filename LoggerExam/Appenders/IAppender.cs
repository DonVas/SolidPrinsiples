namespace LoggerExam.Appenders
{
    public interface IAppender
    {
        void Append(string dateTime, string reportLevel, string message);

    }
}