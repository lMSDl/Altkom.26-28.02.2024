﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.Builder
{
    public class Vehicle
    {

        /*public Vehicle()
        {

        }
        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }
        public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        {
            Doors = doors;
        }
        public Vehicle(int wheels, int seats, int? trunkCapacity) : this(wheels, seats)
        {
            TrunkCapacity = trunkCapacity;
        }
        *//*public Vehicle(int wheels, int seats, int? enginePower) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }*//*
        public Vehicle(int wheels, int? enginePower, int seats) : this(wheels, seats)
        {
            EnginePower = enginePower;
        }
        public Vehicle(int wheels, int seats, int doors, int? trunkCapacity, int? enginePower) : this(wheels, seats, doors)
        {
            TrunkCapacity = trunkCapacity;
            EnginePower = enginePower;
        }*/



        //klasa buildera jako wewnętrzna pozwala ograniczyć sposób tworzenia obiektu
        //przez co obiekt danej klasy może powstać tylko przez użycie buildera
        /*private Vehicle() { }

        public class VehicleBuilder()
        {
            private Vehicle Vehicle = new Vehicle();

            public void SetWeels(int value)
            {
                Vehicle.Wheels = value;
            }

            //....

            public Vehicle Build()
            {
                return Vehicle;
            }
        }*/

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public override string ToString()
        {
            return $"Obiekt ma {Wheels} kół, {Seats} siedzeń, {Doors} drzwi" + (TrunkCapacity.HasValue ? $", pojemność bagażnika {TrunkCapacity}" : "") + (EnginePower.HasValue ? $", moc silnika {EnginePower}HP" : "");
        }

    }
}
