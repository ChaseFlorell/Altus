namespace AltusTest.Core.Changers
{
    public interface IStringChangeHandler
    {
        string Handle(string input);
        bool CanHandle(string input);
        string Output(string input);
    }
}