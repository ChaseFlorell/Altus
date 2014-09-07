using System;
using System.Linq;

namespace AltusTest.Core.Changers
{
    public class ConsonantChanger : StringChangerBase
    {
        private const string _characters = "bcdfghjklmnpqrstvwxyz";

        public override string Handle(string input)
        {
            foreach (char character in input)
            {
                if (_characters.IndexOf(character.ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    input = input.Replace(character, Char.ToUpper(character));
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