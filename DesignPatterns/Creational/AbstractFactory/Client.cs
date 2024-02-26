namespace Altkom._26_28._02._2024.DesignPatterns.Creational.AbstractFactory
{
    internal class Client
    {
        public static void Execute()
        {
            Order order;

            order = new Order("Honda", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order("Toyota", nameof(ISedan), "compact");
            Console.WriteLine(order.ManufacturedCarName());


            order = new Order("Toyota", nameof(ISuv), "full");
            Console.WriteLine(order.ManufacturedCarName());
        }
    }
}
