using System.Threading;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;
        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(time, _cancellationTokenSource.Token).ContinueWith(x =>
            {
                CoffeeMachine.State = new IdleState(CoffeeMachine);
                _cancellationTokenSource.Dispose();
            });
        }

        public override void Large()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }
    }
}