namespace AltusTest.Core.Changers
{
    public class NumberChanger : StringChangerBase
    {
        private const string _characters = "02468";

        public override string Handle(string input)
        {
            foreach (char character in input)
            {
                if ( _characters.IndexOf(character) >= 0)
                {
                    input = input.Replace(character.ToString(), string.Empty);
                }
            }
            return Successor != null ? Successor.Output(input) : input;
        }

        public override bool CanHandle(string input)
        {
            var i = input.IndexOfAny(_characters.ToCharArray());
            var canHandle = i >= 0;
            return canHandle;
        }
    }
}