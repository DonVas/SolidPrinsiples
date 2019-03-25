using System.Linq;

namespace LoggerExam.Loggers
{
    public class LogFile : ILogFile
    {
        public int Size { get;  set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }      
    }
}