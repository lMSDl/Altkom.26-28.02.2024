using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Observer
{
    internal class Client
    {
        public static void Execute()
        {
            var sub1 = new SubscriberA();
            var sub2 = new SubscriberB();

            using (var publisher = new Publisher())
            {

                sub1.Subscription = publisher.Subscribe(sub1);
                sub2.Subscription = publisher.Subscribe(sub2);


                _ = Task.Delay(7000).ContinueWith(x => sub2.OnCompleted());

                _ = Task.Delay(12000).ContinueWith(x => sub2.Subscription = publisher.Subscribe(sub2));

                publisher.Work().Wait();
            }
        }
    }
}
