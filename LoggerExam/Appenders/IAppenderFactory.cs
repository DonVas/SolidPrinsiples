using LoggerExam.Layouts;

namespace LoggerExam.Appenders
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}