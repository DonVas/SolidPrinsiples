using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LoggerExam.Layouts;
using LoggerExam.Loggers;

namespace LoggerExam.Appenders
{
    public class FileAppender : IAppender
    {
        private ILayout layout;
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
        {
            this.layout = layout;
            this.logFile = logFile;
        }
        public void Append(string dateTime, string reportLevel, string message)
        {
            var content = string.Format(this.layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
            File.AppendAllText("log.txt", content);
        }
    }
}
