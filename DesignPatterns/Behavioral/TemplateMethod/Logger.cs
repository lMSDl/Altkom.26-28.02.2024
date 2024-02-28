using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal abstract class Logger<T, TService> where TService : IDisposable
    {
        public void Log(string message)
        {
            BeforePrepareMessage();
            message = PrepareMessage(message);


            using TService service = GetService();

            T item = CreateItem(message);
            
            Save(item, service);


        }

        protected virtual void BeforePrepareMessage()
        {
        }

        protected abstract void Save(T item, TService? service);
        protected abstract T CreateItem(string message);
        protected abstract TService GetService();
        protected virtual string PrepareMessage(string message)
        {
            return $"{DateTime.Now}: {message}";
        }
    }
}
