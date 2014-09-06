using System;
using AltusTest.Core.Exceptions;
using AltusTest.Core.Properties;

namespace AltusTest.Core.Drawing
{
    public class Canvas
    {
        private readonly Shape _shapeToDraw;

        public Canvas(Shape shapeToDraw)
        {
            _shapeToDraw = shapeToDraw;
        }

        public Canvas(string shapeToDraw)
        {
            shapeToDraw = shapeToDraw.ToLower();

            switch (shapeToDraw)
            {
                case "circle" : _shapeToDraw = Shape.Circle;
                    break;
                case "line": _shapeToDraw = Shape.Line;
                    break;
                case "box" : _shapeToDraw = Shape.Box;
                    break;
                default :
                    throw new InvalidShapeException(string.Format(Resources.app_InvalidShapeExceptionMessage, shapeToDraw));
            }
        }

        public string Draw()
        {
            throw  new NotImplementedException();
        }

        public class Circle
        {
            public static string Draw()
            {
                throw new System.NotImplementedException();
            }
        }

        public class Box
        {
            public static string Draw()
            {
                throw new System.NotImplementedException();
            }
        }

        public class Line
        {
            public static string Draw()
            {
                throw new System.NotImplementedException();
            }
        }
    }

    public enum Shape
    {
        Circle,
        Line,
        Box
    }
}