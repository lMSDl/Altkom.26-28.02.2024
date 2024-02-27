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
            FlyweightFactory.Instance.Initialize(
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" });

            Console.WriteLine(FlyweightFactory.Instance);

            var car1 = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };
            //car1.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(car1.CarFlyweight);

            var car2 = new Car
            {
                Number = "CL4127A",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };
            //car2.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(car2.CarFlyweight);

            Console.WriteLine(FlyweightFactory.Instance);

            var car3 = new Car
            {
                Number = "CL537A",
                Owner = "Tom Uptown",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };
            //car3.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(car3.CarFlyweight);

            /*var flyweight = (CarFlyweight)car2.CarFlyweight.Clone();
            flyweight.Color = "green";
            car2.CarFlyweight = FlyweightFactory.Instance.GetFlyweight(flyweight);*/

            car2.Color = "green";
        }
    }
}
