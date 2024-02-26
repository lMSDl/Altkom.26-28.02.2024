using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder()
    {
        private Vehicle Vehicle = new Vehicle();

        public void SetWeels(int value)
        {
            Vehicle.Wheels = value;
        }
        public void SetDoors(int value)
        {
            Vehicle.Doors = value;
        }
        public void SetEngine(int? value)
        {
            Vehicle.EnginePower = value;
        }
        public void SetTrunk(int? value)
        {
            Vehicle.TrunkCapacity = value;
        }
        public void SetSeets(int value)
        {
            Vehicle.Seats = value;
        }

        public Vehicle Build()
        {
            return Vehicle;
        }
    }
}
