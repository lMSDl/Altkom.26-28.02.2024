using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Bridge
{
    internal abstract class Tone
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
