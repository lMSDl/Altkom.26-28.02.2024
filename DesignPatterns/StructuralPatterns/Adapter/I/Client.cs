using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };
            Square square = new Square() { A = 8 };

            CheckR(circle);
            CheckR(new SquareToCircleAdapter(square));
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
