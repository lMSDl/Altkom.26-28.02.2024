using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class Client
    {
        public static void Execute()
        {
            var collection = new IElement[]
{
                new PlainText() {Text = "Plain"},
                new PlainText() { Text = "\n" },
                new BoldText() {Text = "Bold"},
                new PlainText() { Text = "\n" },
                new Hyperlink() {Text = "Hyperlink",  Link=@"https:\\some.url.pl"}
};


            var builder = new StringBuilder();

            foreach (var item in collection)
            {
                builder.Append(item.ToHtml());
            }
            Console.WriteLine( builder.ToString());
        }
    }
}
