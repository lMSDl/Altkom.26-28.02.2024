using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Bridge
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);
            Color color = new Red();
            Console.WriteLine(color);

            shape.Color = color;
            Console.WriteLine(shape);

            color.Tone = new Light();

            Console.WriteLine(shape);
        }
    }
}
