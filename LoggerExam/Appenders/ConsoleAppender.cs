using System;
using LoggerExam.Layouts;
using LoggerExam.Loggers.Enums;

namespace LoggerExam.Appenders
{
    public class ConsoleAppender : Appender
    {

        public ConsoleAppender(ILayout layout)
            :base(layout)
        {           
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessagesCount++;
            }
            
        }
    }
}
