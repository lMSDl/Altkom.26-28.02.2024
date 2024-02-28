using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Observer
{
    internal class SubscriberB : Subsciber
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
                Console.WriteLine("SubscriberB zareagował");
        }

        public override void OnError(Exception error)
        {
            base.OnError(error);
            OnCompleted();
        }
    }
}
