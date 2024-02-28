namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Visitor.II
{
    internal class BoxedProduct : Product
    {
        public override void PrintType()
        {
            Console.WriteLine("BoxedProduct");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}