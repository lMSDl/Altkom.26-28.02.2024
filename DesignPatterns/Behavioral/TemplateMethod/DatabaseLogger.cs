using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger
    {
        public void Log(string message)
        {
            string messageToLog = SerializeMessage(message);
            ConnectToDatabase();
            InsertLogMessageToTable(messageToLog);
            CloseDbConnection();
        }
        private string SerializeMessage(object message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
        private void ConnectToDatabase()
        {
            Console.WriteLine("Connecting to Database.");
        }
        private void InsertLogMessageToTable(string message)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + message);
        }
        private void CloseDbConnection()
        {
            Console.WriteLine("Closing DB connection.");
        }
    }
}
