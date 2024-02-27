using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Decorator
{
    internal class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();
                INotification notification = CreateNotification();

                notification.Send(text);
            }
        }

        private static INotification CreateNotification()
        {
            INotification notification = new SystemNotification();

            if (DateTime.Now.Second % 2 == 0)
            {
                notification = new EmailNotification(notification);
            }
            if (DateTime.Now.Second % 3 == 0)
            {
                notification = new SmsNotification(notification);
            }

            return notification;
        }
    }
}
