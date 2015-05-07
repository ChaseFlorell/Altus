using System;
using AltusTest.Core.Drawing;
using AltusTest.Core.Properties;

namespace AltusTest.ConsoleDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMessageService.WriteMessage(Resources.app_DrawInstructions, false);
            while (true)
            {
                var shape = Console.ReadLine();
                try
                {
                    if (string.IsNullOrWhiteSpace(shape))
                    {
                        var canvas = new Canvas();
                        Console.WriteLine(canvas.Draw());
                    }
                    else
                    {
                        var canvas = new Canvas(shape);
                        Console.WriteLine(canvas.Draw());
                    }

                    ConsoleMessageService.WriteMessage(Resources.app_TryAnInvalidString);
                }
                catch (Exception ex)
                {
                    ConsoleMessageService.WriteErrorMessage(ex);
                    ConsoleMessageService.WriteMessage(Resources.app_DrawInstructions);
                }
            }
        }
    }
}
