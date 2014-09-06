using AltusTest.Core.Drawing;
using AltusTest.Core.Exceptions;
using AltusTest.Core.Properties;
using NUnit.Framework;

namespace AltusTest.Tests.Unit
{
    [TestFixture]
    public class DrawingTests
    {
        [Test]
        public void ShouldDrawACircle()
        {
            // setup
            var expected = Resources.app_DrawingACircle;
            
            // execute
            var actual = Canvas.Circle.Draw();

            // assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void ShouldDrawABox()
        {
            // setup
            var expected = Resources.app_DrawingABox;

            // execute
            var actual = Canvas.Box.Draw();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldDrawALine()
        {
            // setup
            var expected = Resources.app_DrawingALine;

            // execute
            var actual = Canvas.Line.Draw();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldDrawWhatITellItToFromString()
        {
            // setup
            var canvas = new Canvas("Box");
            var expected = Resources.app_DrawingABox;

            // execute
            var actual = canvas.Draw();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldDrawWhatITellItToFromEnum()
        {
            // setup
            var canvas = new Canvas(Shape.Box);
            var expected = Resources.app_DrawingABox;

            // execute
            var actual = canvas.Draw();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldThrowOnUnknownShape()
        {
            // setup
            const Shape shapeToDraw = (Shape)4;

            // assert
            var ex = Assert.Throws<InvalidShapeException>(() => new Canvas(shapeToDraw).Draw());
            Assert.That(ex.Message, Is.EqualTo(string.Format(Resources.app_InvalidShapeExceptionMessage, "unknown")));
        }

        [Test]
        public void ShouldThrowOnInvalidShape()
        {
            // setup
            const string shapeToDraw = "Hexagon";
            Canvas canvas;

            // assert
            var ex = Assert.Throws<InvalidShapeException>(() => canvas = new Canvas(shapeToDraw));
            Assert.That(ex.Message, Is.EqualTo(string.Format(Resources.app_InvalidShapeExceptionMessage, shapeToDraw)));
        }
    }
}