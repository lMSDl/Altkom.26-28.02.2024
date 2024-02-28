using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger
    {
        public void Log(object message)
        {
            string messageToLog = SerializeMessage(message);
            OpenFile();
            WriteLogMessage(messageToLog);
            CloseFile();
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private void OpenFile()
        {
            Console.WriteLine("Opening File.");
        }
        private void WriteLogMessage(string message)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }
        private void CloseFile()
        {
            Console.WriteLine("Close File.");
        }
    }
}
