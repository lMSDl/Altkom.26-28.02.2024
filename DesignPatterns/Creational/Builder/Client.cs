using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            //var builder = new Vehicle.VehicleBuilder();

            var builder = new VehicleBuilder();
            builder.SetWeels(4);
            builder.SetDoors(4);
            builder.SetTrunk(500);
            builder.SetSeets(5);
            builder.SetEngine(150);


            var vehicle = builder.Build();
            Console.WriteLine(vehicle);


            vehicle = new Vehicle() { Doors = 4, EnginePower = 150, TrunkCapacity = 500, Seats = 5, Wheels = 4 };
            Console.WriteLine(vehicle);

        }
    }
}
