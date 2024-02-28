using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        private StringBuilder StringBuilder { get; } = new StringBuilder();

        public void Visit(PlainText element)
        {
            StringBuilder.Append(element.Text);
        }

        public void Visit(BoldText element)
        {
            StringBuilder.Append($"<b>{element.Text}</b>");
        }

        public void Visit(Hyperlink element)
        {
            StringBuilder.Append($"<a href={element.Link}>{element.Text}</a>");
        }
        public override string ToString()
        {
            return StringBuilder.ToString();
        }
    }
}
