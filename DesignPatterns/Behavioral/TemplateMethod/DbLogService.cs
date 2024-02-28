using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogService : IDisposable
    {
        public DbLogService()
        {
            Console.WriteLine("Connecting to Database.");
        }

        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Write(DbLog message)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + message.Message);
        }
    }
}
