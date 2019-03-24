using System;
using System.Collections.Generic;
using System.Text;
using LoggerExam.Layouts;

namespace LoggerExam.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }
        public void Append(string dateTime, string reportLevel, string message)
        {
            Console.WriteLine(string.Format(this.layout.Format,dateTime,reportLevel,message));
        }
    }
}
