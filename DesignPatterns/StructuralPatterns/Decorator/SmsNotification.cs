using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.StructuralPatterns.Decorator
{
    internal class SmsNotification : BaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        public const int MaxLengh = 16;
        protected override void ExtraSend(string message)
        {
            foreach (var item in Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLengh))
                                           .Select(x => message.Substring(x * MaxLengh, Math.Min(MaxLengh, message.Length - x * MaxLengh))))
            {
                Console.WriteLine($"SMS: {item}");
            }
        }
    }
}
