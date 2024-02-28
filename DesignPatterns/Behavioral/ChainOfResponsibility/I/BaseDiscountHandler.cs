using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal abstract class BaseDiscountHandler : IDiscountHandler
    {
        private readonly IDiscountHandler? _discountHandler;

        public BaseDiscountHandler(IDiscountHandler? discountHandler)
        {
            _discountHandler = discountHandler;
        }

        public BaseDiscountHandler()
        {
        }

        public virtual bool Discount(float value, float price)
        {
            return _discountHandler?.Discount(value, price) ?? false;
        }
    }
}
