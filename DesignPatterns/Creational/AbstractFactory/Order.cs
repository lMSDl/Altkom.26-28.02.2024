using Altkom._26_28._02._2024.SOLID.L;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Order
    {
        private readonly ICar _car;

        public Order(string manufacturer, string type, string segment)
        {
            var factory = CreateFactory(manufacturer);

            switch(type)
            {
                case nameof(ISedan):
                    _car = factory.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = factory.ManufactureSuv(segment);
                    break;
            }
        }

        private static ICarFactory CreateFactory(string manufacturer)
        {
            switch (manufacturer)
            {
                case "Honda":
                    return new HondaFactory();
                case "Toyota":
                    return new ToyotaFactory();
            }
            return null;
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}
