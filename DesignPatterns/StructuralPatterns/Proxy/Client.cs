using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();

            for (int i = 1; i < 11; i++)
            {
                database.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(250);
                database.RequestAsync(i);
            }

            Console.ReadKey();
        }
    }
}
