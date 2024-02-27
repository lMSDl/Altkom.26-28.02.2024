using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.ObjectPool
{
    public class Item
    {
        public Item()
        {
        }

        public bool IsVisible { get; set; }

        public byte[] Content { get; } = new byte[10240];

    }
}
