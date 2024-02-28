using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Command
{
    internal class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new AddToGardenCommand(garden, "drzewo");
            var command2 = new RemoveFromGardenCommand(garden, "drzewo");
            var command3 = new AddToGardenCommand(garden, "kwiaty");
            var command4 = new RemoveFromGardenCommand(garden, "kwiaty");

            var plantTreeButton = new Invoker(command1);
            var removeTreeButton = new Invoker(command2);
            var plantFlowersButton = new Invoker(command3);
            var removeFlowersButton = new Invoker(command4);

            Console.WriteLine(garden);

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();

            Console.WriteLine(garden);

            plantFlowersButton.Invoke();
            plantFlowersButton.Invoke();
            plantFlowersButton.Invoke();

            Console.WriteLine(garden);


            removeTreeButton.Invoke();
            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();

            Console.WriteLine(garden);

            Invoker.Undo();
            Invoker.Undo();
            Invoker.Undo();
            Invoker.Undo();
            Console.WriteLine(garden);
        }
    }
}
