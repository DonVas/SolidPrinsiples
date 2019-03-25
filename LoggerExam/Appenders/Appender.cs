using LoggerExam.Layouts;
using LoggerExam.Loggers.Enums;

namespace LoggerExam.Appenders
{
    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public int MessagesCount { get; protected set; }

        protected ILayout Layout { get; }
    
        public ReportLevel ReportLevel { get ; set ; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessagesCount}";
        }

    }
}
