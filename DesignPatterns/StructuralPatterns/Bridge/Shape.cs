using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Bridge
{
    internal abstract class Shape
    {
        public Color? Color { get; set; }

        public override string ToString()
        {
            return (Color?.ToString() ?? "") + GetType().Name;
        }
    }
}
