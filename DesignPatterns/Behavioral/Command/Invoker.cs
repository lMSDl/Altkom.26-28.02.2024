using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Command
{
    internal class Invoker
    {
        private readonly static Stack<ICommand> _commands = new Stack<ICommand>();
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
            _commands.Push(_command);
        }

        public static void Undo()
        {
            if (_commands.TryPop(out var command))
            {
                command.Reverse();
            }
        }
    }
}
