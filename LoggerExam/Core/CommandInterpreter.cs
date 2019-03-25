using System;
using System.Collections.Generic;
using System.Text;
using LoggerExam.Appenders;
using LoggerExam.Layouts;
using LoggerExam.Loggers.Enums;

namespace LoggerExam.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory =new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }
        public void AddAppender(string[] args)
        {
            string typeAppender = args[0];
            string typeLayout = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length==3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            ILayout layout = this.layoutFactory.CreateLayout(typeLayout);
            IAppender apender = this.appenderFactory.CreateAppender(typeAppender, layout);
            apender.ReportLevel = reportLevel;
            appenders.Add(apender);
        }

        public void AddReport(string[] args)
        {
            string reportType = args[0];
            string dateTime = args[1];
            string message = args[2];
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(reportType);

            foreach (var appender in appenders)
            {
                appender.Append(dateTime,reportLevel,message);
            }
        }

        public void PrintInfo()
        {
            var builder = new StringBuilder();

            builder.AppendLine("Logger info");

            foreach (var appender in this.appenders)
            {
                builder.AppendLine(appender.ToString());
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
