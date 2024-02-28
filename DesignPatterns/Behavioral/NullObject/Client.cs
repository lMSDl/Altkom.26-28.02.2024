using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.NullObject
{
    internal class Client
    {
        public static void Execute()
        {
            //var objects = new AbstractObject?[] { new RealObject(), null };
            var objects = new AbstractObject[] { new RealObject(), new NullObject() };
            var random = new Random();

            while (true)
            {
                var value = random.Next(0, objects.Length);
                Console.ReadLine();

                /*if(objects[value] != null)
                    objects[value].Method1();

                objects[value]?.Method2();

                if (objects[value] is not null)
                    objects[value].Method3();*/

                objects[value].Method1();
                objects[value].Method2();
                objects[value].Method3();
            }
        }
    }
}
