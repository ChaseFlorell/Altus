using System;
namespace AltusTest.ConsoleDraw
{
    internal static class ConsoleMessageService
    {
        public static void WriteErrorMessage(Exception exception)
        {
            var originalForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ForegroundColor = originalForegroundColor;
        }

        internal static void WriteMessage(string instructions, bool includeNewLine = true)
        {
            if (includeNewLine)
            {
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine(instructions);
            Console.WriteLine(@"----------------------------");
        }
    }
}