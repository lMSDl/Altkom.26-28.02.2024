using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Strategy
{
    internal class MultiplyStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a * b;
        }
    }
}
