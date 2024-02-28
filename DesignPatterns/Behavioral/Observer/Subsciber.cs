using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Observer
{
    internal abstract class Subsciber : IObserver<int>
    {
        public IDisposable? Subscription { get; set; }

        public void OnCompleted()
        {
            if (Subscription is null)
                return;
            Console.WriteLine($"{GetType().Name} odłączył się");
            Subscription?.Dispose();
            Subscription = null;
        }

        public virtual void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name} otrzymał powiadomienie o błędzie: {error}");
        }

        public abstract void OnNext(int value);
    }
}
