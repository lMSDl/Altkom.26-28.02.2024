namespace Altkom._26_28._02._2024.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 3;

           elevator.Execute(action, floor);


            action = "Up";
            floor = 5;

            elevator.Execute(action, floor);


            action = "GoTo";
            floor = 5;

            elevator.Execute(action, floor);
        }
    }
}
