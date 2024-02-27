using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Adapter.I
{
    internal class SquareToCircleAdapter : ICircle
    {
        private readonly Square _square;

        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

        public double R => _square.A * Math.Sqrt(2) / 2.0;
    }
}
