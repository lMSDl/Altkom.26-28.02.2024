namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Mediator
{
    internal abstract class ChatMemeber
    {
        private IMediator mediator;
        public string Nick { get; set; }
        public IMediator Mediator
        {
            get => mediator;
            set
            {
                mediator?.Quit(this);
                mediator = value;
                mediator?.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}