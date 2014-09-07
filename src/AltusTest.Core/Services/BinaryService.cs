using System;
using System.Collections.Generic;
using System.Linq;

namespace AltusTest.Core.Services
{
    public class BinaryService
    {
        public string BinCount(decimal input)
        {
            var binaries = new Stack<string>(); // stack is reversed, so we're actually building the collection backwards (counting up).

            for (var i = 0; i <= input; i++)
            {
                binaries.Push(DecimalToBin(i));
            }
            return string.Join(" ", binaries);
        }

        private static string DecimalToBin(decimal number)
        {
            var decimalNumber = (int)number;

            var result = string.Empty;
            while (decimalNumber > 0)
            {
                var remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder + result;
            }

            return result.PadLeft(2,'0'); // padded to allow for 1 and 0.
        }

        private static decimal BinToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2); // didn't use ToList() ;-)
        }

        public bool VerifyBinary(string binaryString, decimal expectedFirstNumber)
        {
            var numbers = binaryString.Split(' ');
            var collection = new decimal[(int)expectedFirstNumber-1];

            for (var i = 0; i <= collection.Length-1; i++)
            {
                collection[i] = BinToDecimal(numbers[i]);
            }

            var numberIsCorrect = collection[0] == expectedFirstNumber;
            var isSequential = Enumerable.Range(0, collection.Length).Any(i => collection[i] != collection[0] + i);

            return numberIsCorrect && isSequential;
        }
    }
}