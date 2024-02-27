using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {
        public static void Execute()
        {
            var counter = 0;
            while(true)
            {
                if( counter > 1000)
                {
                    Thread.Sleep(1);
                    continue;
                }

                var item = new Item();
                item.IsVisible= true;
                Task.Delay(100).ContinueWith(t => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
                Interlocked.Increment(ref counter);
            }
        }
        }
    }
