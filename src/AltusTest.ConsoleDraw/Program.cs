using System;
using AltusTest.Core.Drawing;
using AltusTest.Core.Exceptions;
using AltusTest.Core.Properties;

namespace AltusTest.ConsoleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            var runCount = 1;
            while (true)
            {
                Console.WriteLine(runCount%2 == 0 ? Resources.app_TryAnInvalidString : Resources.app_DrawInstructions);
                Console.WriteLine(@"----------------------------");
                var shape = Console.ReadLine();
                try
                {
                    if (!string.IsNullOrWhiteSpace(shape))
                    {
                        var canvas = new Canvas(shape);
                        Console.WriteLine(canvas.Draw());
                    }
                    else
                    {
                        var canvas = new Canvas();
                        Console.WriteLine(canvas.Draw());
                    }
                }
                catch (InvalidShapeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write(Environment.NewLine + Environment.NewLine);
                runCount++;
            }
        }
    }
}
