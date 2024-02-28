using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberA : Subsciber
    {
        public override void OnNext(int value)
        {
            if (value > 30)
            {
                Console.WriteLine("SubscriberA rozpoczął reagowanie");

                Thread.Sleep(new Random(value).Next(1000, 5000));

                Console.WriteLine("SubscriberA zareagował");
            }
        }
    }
}
