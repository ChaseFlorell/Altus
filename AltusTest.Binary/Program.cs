using System;
using AltusTest.Core;
using AltusTest.Core.Properties;
using AltusTest.Core.Services;
using Autofac;

namespace AltusTest.Binary
{
    class Program
    {
        private static IBinaryService _binaryService;

        static void Main(string[] args)
        {
            InitializeIoCContainer();

            while (true)
            {
                ConsoleMessageService.WriteMessage(Resources.app_BinaryInstructions);
                var numberString = Console.ReadLine();
                int number;
                int.TryParse(numberString, out number);

                try
                {
                    Console.WriteLine(_binaryService.BinCount(number));
                }
                catch (Exception ex)
                {
                    ConsoleMessageService.WriteErrorMessage(ex);
                }
            }
        }

        private static void InitializeIoCContainer()
        {
            var container = new CoreIoC().Load();
            _binaryService = container.Resolve<IBinaryService>();
        }
    }
}
