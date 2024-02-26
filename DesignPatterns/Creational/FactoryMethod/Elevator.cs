using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {

        private readonly Dictionary<string, IElevatorOperation?> _operations = new Dictionary<string, IElevatorOperation?>();

        public void Execute(IElevatorOperation? operation, int floor)
        {
            operation?.Operate(floor);
        }

        public void Execute(string action, int floor)
        {
            Execute(CreateOperation(action), floor);
        }

        private IElevatorOperation? CreateOperation(string action)
        {
            if (_operations.TryGetValue(action, out var elevatorOperation))
                return elevatorOperation;

            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    elevatorOperation = new ElevatorGoTo();
                    break;
            }

            _operations[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}
