using AltusTest.Core.Changers;
using AltusTest.Core.Services;
using Autofac;

namespace AltusTest.Core
{
    public class CoreIoC
    {
        private readonly ContainerBuilder _builder;

        /// <summary>
        /// Create the CoreIoC with an empty ContainerBuilder
        /// </summary>
        public CoreIoC()
        {
            _builder = new ContainerBuilder();
        }

        /// <summary>
        /// Creates the CoreIoC with a pre-populated ContainerBuilder
        /// </summary>
        /// <param name="builder">Platform Specific ContainerBuilder</param>
        public CoreIoC(ContainerBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// Load all core dependencies
        /// </summary>
        /// <returns>A Hydrated Autofac Container</returns>
        /// <remarks>Contains, IStringChangeHandler, IStringService, and IBinaryService</remarks>
        public IContainer Load()
        {
            _builder.RegisterInstance(new ConsonantChanger().AddToChain(new VowelChanger().AddToChain(new NumberChanger()))).As<IStringChangeHandler>();
            _builder.RegisterType<StringService>().As<IStringService>();
            _builder.RegisterType<BinaryService>().As<IBinaryService>();

            return _builder.Build();
        }
    }
}