using System.Diagnostics;
using AltusTest.Core.Changers;
using AltusTest.Core.Services;
using NUnit.Framework;

namespace AltusTest.Tests.Unit
{
    [TestFixture]
    public class StringChangerTests
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
            Trace.WriteLine(actual);
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
            Trace.WriteLine(actual);
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
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldSatisfyTestExample()
        {
            // setup
            const string original = @"alphabet0123";
            const string expected = @"aLPHaBeT13";

            // execute
            var actual = _stringService.ChangeCase(original);

            // assert
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldHandleNumber()
        {
            // setup
            const string toHandle = "123";
            const string expected = "13";
            var changer = new NumberChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsTrue(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldHandleNotNumberWithStringOnly()
        {
            // setup
            const string toHandle = "abc";
            const string expected = "abc";
            var changer = new NumberChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsFalse(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldHandleVowels()
        {
            // setup
            const string toHandle = "ABC";
            const string expected = "aBC";
            var changer = new VowelChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsTrue(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldNotHandleVowelsWithNumberOnly()
        {
            // setup
            const string toHandle = "123";
            const string expected = "123";
            var changer = new VowelChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsFalse(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldHandleConsonants()
        {
            // setup
            const string toHandle = "abc";
            const string expected = "aBC";
            var changer = new ConsonantChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsTrue(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }

        [Test]
        public void ShouldNotHandleConsonantsWithNumberOnly()
        {
            // setup
            const string toHandle = "123";
            const string expected = "123";
            var changer = new ConsonantChanger();

            // execute
            var canHandle = changer.CanHandle(toHandle);
            var actual = changer.Handle(toHandle);

            // assert
            Assert.IsFalse(canHandle);
            Assert.AreEqual(expected, actual);
            Trace.WriteLine(actual);
        }
    }
}