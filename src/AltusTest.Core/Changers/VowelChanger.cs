using System;

namespace AltusTest.Core.Changers
{
    public class VowelChanger : StringChangerBase
    {
        private const string _characters = "aeiou";

        public override string Handle(string input)
        {
            foreach (char character in input)
            {
                if (_characters.IndexOf(character.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    input = input.Replace(character, Char.ToLower(character));
                }
            }
            return Successor != null ? Successor.Output(input) : input;
        }

        public override bool CanHandle(string input)
        {
            var i = input.ToLowerInvariant().IndexOfAny(_characters.ToCharArray());
            var canHandle = i >= 0;
            return canHandle;
        }
    }
}