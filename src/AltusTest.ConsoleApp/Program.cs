using System;
using AltusTest.Core;
using AltusTest.Core.Properties;
using AltusTest.Core.Services;
using Autofac;

namespace AltusTest.ConsoleApp
{
    class Program
    {
        private static IStringService _stringService;

        static void Main(string[] args)
        {
            InitializeIoCContainer();


            while (true)
            {
                Console.WriteLine(Resources.app_Instructions);
                Console.WriteLine(@"----------------------------");
                Console.WriteLine(_stringService.ChangeCase(Console.ReadLine()));
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        private static void InitializeIoCContainer()
        {
            var container = new CoreIoC().Load();
            _stringService = container.Resolve<IStringService>();
        }
    }
}
