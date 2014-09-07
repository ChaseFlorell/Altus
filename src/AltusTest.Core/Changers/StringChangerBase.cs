namespace AltusTest.Core.Changers
{
    public abstract class StringChangerBase : IStringChangeHandler
    {
        protected StringChangerBase Successor;

        public abstract string Handle(string input);
        public abstract bool CanHandle(string input);

        public string Output(string input)
        {
            if (CanHandle(input))
            {
                return Handle(input);
            }

            return Successor != null ? Successor.Output(input) : input;
        }

        public StringChangerBase AddToChain(StringChangerBase successor)
        {
            Successor = successor;
            return this;
        }
    }
}