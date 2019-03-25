using System;

namespace LoggerExam.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter command;
  

        public Engine(ICommandInterpreter command)
        {
            this.command = command;
        }

        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderArgs = Console.ReadLine()
                    .Split();

                this.command.AddAppender(appenderArgs);
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] reportArgs = input
                    .Split("|");

                this.command.AddReport(reportArgs);

                input = Console.ReadLine();
            }

            this.command.PrintInfo();
        }
    }
}
