namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Visitor.II
{
    internal class Product : IElement
    {
        public virtual void PrintType()
        {
            Console.WriteLine("Product");
        }

        public virtual void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}