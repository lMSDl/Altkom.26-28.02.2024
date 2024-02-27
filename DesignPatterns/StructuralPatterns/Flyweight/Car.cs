using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Flyweight
{
    internal class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Manufacturer { get => CarFlyweight.Manufacturer; set => SetValue(x => x.Manufacturer = value); }
        public string Model { get => CarFlyweight.Model; set => SetValue(x => x.Model = value); }
        public string Color { get => CarFlyweight.Color; set => SetValue(x => x.Color = value); }

        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();

        private void SetValue(Action<CarFlyweight> action)
        {
            var clone = (CarFlyweight)CarFlyweight.Clone();
            action(clone);
            CarFlyweight = FlyweightFactory.Instance.GetFlyweight(clone);
        }

        public string GetInfo()
        {
            return CarFlyweight.GetInfo(this);
        }
    }
}
