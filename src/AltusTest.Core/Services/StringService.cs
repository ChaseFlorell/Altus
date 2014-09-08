using AltusTest.Core.Changers;

namespace AltusTest.Core.Services
{
    public class StringService : IStringService
    {
        private readonly IStringChangeHandler _stringChangeHandler;

        public StringService(IStringChangeHandler stringChangeHandler)
        {
            _stringChangeHandler = stringChangeHandler;
        }

        public string ChangeCase(string original)
        {
            return _stringChangeHandler.Output(original);
        }
    }
}