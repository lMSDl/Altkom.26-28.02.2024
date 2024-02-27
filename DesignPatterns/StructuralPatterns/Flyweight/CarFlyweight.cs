using Altkom._26_28._02._2024.DesignPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Flyweight
{
    internal class CarFlyweight : ICloneable
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string GetInfo(Car car)
        {
            return $"{car.Owner} : {car.Number} : {Manufacturer} : {Model} : {Color}";
        }
    }
}
