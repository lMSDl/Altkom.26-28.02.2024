using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Composite
{
    internal abstract class Leaf : IComponent
    {
        public string Name => GetType().Name;
        public float Price { get; set; }

        protected Leaf(float price)
        {
            Price = price;
        }

        public float GetValue()
        {
            Console.WriteLine($"Wartość {Name} to {Price}");
            return Price;
        }
    }
}
