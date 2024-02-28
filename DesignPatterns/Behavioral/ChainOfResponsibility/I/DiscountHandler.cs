using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandler : BaseDiscountHandler
    {
        protected float MaxDiscount { get; }
        protected float MinPrice { get; }
        private string Name { get; }


        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler? handler) : base(handler)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
            Name = name;
        }
        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }

        public override bool Discount(float value, float price)
        {
            if (value > MaxDiscount || price < MinPrice)
                return base.Discount(value, price);

            Console.WriteLine($"{Name} udzielił rabatu {value}");
            return true;
        }
    }
}
