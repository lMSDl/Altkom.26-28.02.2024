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

        public VehicleBuilder SetWeels(int value)
        {
            Vehicle.Wheels = value;
            return this;
        }
        public VehicleBuilder SetDoors(int value)
        {
            Vehicle.Doors = value;
            return this;
        }
        public VehicleBuilder SetEngine(int? value)
        {
            Vehicle.EnginePower = value;
            return this;
        }
        public VehicleBuilder SetTrunk(int? value)
        {
            Vehicle.TrunkCapacity = value;
            return this;
        }
        public VehicleBuilder SetSeets(int value)
        {
            Vehicle.Seats = value;
            return this;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
