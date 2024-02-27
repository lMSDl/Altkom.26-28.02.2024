using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            var car1 = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };

            var car2 = new Car
            {
                Number = "CL4127A",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };
        }
    }
}
