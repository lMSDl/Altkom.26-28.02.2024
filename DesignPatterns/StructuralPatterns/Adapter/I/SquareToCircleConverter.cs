using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Adapter.I
{
    internal static class SquareToCircleConverter
    {
        public static Circle ToCircle(this Square square)
        {
            return new Circle() { R = square.A * Math.Sqrt(2) / 2 };
        }
    }
}
