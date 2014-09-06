using AltusTest.Core.Extensions;
using NUnit.Framework;

namespace AltusTest.Tests.Unit
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void ShouldConvertStringToTitleCase()
        {
            // setup
            const string original = "HELLO WORLD";
            const string expected = "Hello World";

            // execute
            var actual = original.ToTitleCase();

            // assert
            Assert.AreEqual(expected,actual);
        }

    }
}