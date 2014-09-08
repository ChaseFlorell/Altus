using System;
using AltusTest.Core;
using AltusTest.Core.Exceptions;
using AltusTest.Core.Properties;
using AltusTest.Core.Services;
using Autofac;
using NUnit.Framework;

namespace AltusTest.Tests.Unit
{
    [TestFixture]
    public class BinaryTests
    {
        private IBinaryService _binaryService;

        [SetUp]
        public void SetUp()
        {
            var container = new CoreIoC().Load();
            _binaryService = container.Resolve<IBinaryService>();
        }

        [Test]
        public void ShouldNotRunWithDecimalLargerThanOneHundred()
        {
            // setup 
            const decimal validNumber = 100;
            const decimal invalidNumber = 101;

            // execute
            var validBinary = _binaryService.BinCount(validNumber);
            var ex = Assert.Throws<BinaryCountException>(() => _binaryService.BinCount(invalidNumber));
            var verifiedBinary = _binaryService.VerifyBinary(validBinary, validNumber);

            // assert
            Assert.IsTrue(verifiedBinary);
            Assert.That(ex.Message, Is.EqualTo(string.Format(Resources.app_BinaryCountException, invalidNumber)));
        }

        [Test]
        public void ShouldNotRunWithZeroOrLess()
        {
            // setup 
            const decimal validNumber = 1;
            const decimal invalidNumber = 0;

            // execute
            var validBinary = _binaryService.BinCount(validNumber);
            var ex = Assert.Throws<BinaryCountException>(() => _binaryService.BinCount(invalidNumber));
            var verifiedBinary = _binaryService.VerifyBinary(validBinary, validNumber);

            // assert
            Assert.IsTrue(verifiedBinary);
            Assert.That(ex.Message, Is.EqualTo(string.Format(Resources.app_BinaryCountException, invalidNumber)));
        }

        [Test]
        public void ShouldCountDownFromDecimalInBinary()
        {
            // setup
            const decimal original = 88;

            // execute
            var binary = _binaryService.BinCount(original);
            var verified = _binaryService.VerifyBinary(binary, original);

            // assert
            Assert.IsTrue(verified);
        }

        [Test]
        public void ShouldSatisfyTestExample()
        {
            // setup
            const decimal original = 5;
            const string expected = @"101 100 11 10 01 00";

            // execute
            var actual = _binaryService.BinCount(original);
            var verified = _binaryService.VerifyBinary(actual, original);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(verified);
        }

        [Test]
        public void ShouldVerifyBinaryString()
        {
            // setup
            const decimal firstNumber = 5;
            const string binaryString= @"101 100 11 10 01 00";

            // execute
            var verified = _binaryService.VerifyBinary(binaryString, firstNumber);

            // assert
            Assert.IsTrue(verified);
        }

        [Test]
        public void ShouldThrowOnInvalidBinaryString()
        {
            // setup
            const string invalidString = @"hello world";

            // execute
            Action execute = () => _binaryService.VerifyBinary(invalidString, 5);

            // assert
            Assert.Throws<FormatException>(() => execute());
        }
    }
}