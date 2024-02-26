using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.SOLID.L
{

    abstract class Vehicle
    {
        public string Name { get; set; }
        //public abstract void Fly();
        public abstract void Move();
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("I am drivig!");
        }

        public override void Move()
        {
            Drive();
        }
    }
}
