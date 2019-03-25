using System;
using System.IO;
using System.Linq;
using LoggerExam.Layouts;
using LoggerExam.Loggers;
using LoggerExam.Loggers.Enums;

namespace LoggerExam.Appenders
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;
        private string path = "../../../log.txt";

        public FileAppender(ILayout layout, ILogFile logFile)
        :base(layout)
        {
            this.logFile = logFile;
        }

        public ReportLevel ReportLevel { get; set; }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {         
            if (this.ReportLevel<= reportLevel)
            {
                var content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                File.AppendAllText(path, content);
                this.MessagesCount++;
                this.logFile.Size += content.ToCharArray().Where(Char.IsLetter).Sum(c => c);
            }            
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
