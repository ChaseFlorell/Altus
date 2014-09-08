namespace AltusTest.Core.Services
{
    public interface IBinaryService
    {
        string BinCount(decimal input);
        bool VerifyBinary(string binaryString, decimal expectedFirstNumber);
    }
}