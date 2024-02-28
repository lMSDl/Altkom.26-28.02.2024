using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Buffer<T> : IEnumerable<Tuple<T, T>>
    {
        IEnumerable<T> _items;
        public Buffer(IEnumerable<T> items)
        {
            _items = items;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(_items.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
