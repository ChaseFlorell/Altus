using AltusTest.Core.Changers;

namespace AltusTest.Core.Services
{
    public class StringService
    {
        public string ChangeCase(string original)
        {
            var chainOfResponsibility = new ConsonantChanger()
                .AddToChain(new VowelChanger()
                .AddToChain(new NumberChanger()));

            return chainOfResponsibility.Output(original);
        }
    }
}