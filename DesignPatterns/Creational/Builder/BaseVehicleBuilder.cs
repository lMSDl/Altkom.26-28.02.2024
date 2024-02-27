using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.Builder
{
    internal abstract class BaseVehicleBuilder
    {
        protected Vehicle Vehicle;

        protected BaseVehicleBuilder() : this(new Vehicle())
        {
        }

        protected BaseVehicleBuilder(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
