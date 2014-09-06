using AltusTest.Core.Services;
using NUnit.Framework;

namespace AltusTest.Tests.Unit
{
    [TestFixture]
    public class StringTests
    {
        private StringService _stringService;

        [SetUp]
        public void SetUp()
        {
            _stringService = new StringService();
        }

        [Test]
        public void ShouldReplaceAllVowelsToLower()
        {
            // setup
            const string original = @"AEIOU";
            const string expected = @"aeiou";

            // execute
            var actual = _stringService.ChangeCase(original);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReplaceAllConsonantsToUpper()
        {
            // setup
            const string original = @"bcdfghjklmnpqrstvwxz";
            const string expected = @"BCDFGHJKLMNPQRSTVWXZ";

            // execute
            var actual = _stringService.ChangeCase(original);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldRemoveAllEvenDigits()
        {
            // setup
            const string original = @"0123456789";
            const string expected = @"13579";

            // execute
            var actual = _stringService.ChangeCase(original);

            // assert
            Assert.AreEqual(expected, actual); 
        }

        [Test]
        public void ShouldSatisfyTestExample()
        {
            // setup
            const string original = @"alphabet0123";
            const string expected = @"aLPHaBeT13 ";

            // execute
            var actual = _stringService.ChangeCase(original);

            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}