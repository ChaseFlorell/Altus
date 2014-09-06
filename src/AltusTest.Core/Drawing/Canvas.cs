using System;
using AltusTest.Core.Exceptions;
using AltusTest.Core.Extensions;
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

        public Canvas(string caseInsensitiveShapeToDraw)
        {
            var parsed = Enum.TryParse(caseInsensitiveShapeToDraw.ToTitleCase(), out _shapeToDraw);

            if (!parsed)
            {
                throw new InvalidShapeException(string.Format(Resources.app_InvalidShapeExceptionMessage, caseInsensitiveShapeToDraw));
            }
        }

        public string Draw()
        {
            switch (_shapeToDraw)
            {
                case Shape.Box:
                    return Box.Draw();
                case Shape.Circle:
                    return Circle.Draw();
                case Shape.Line:
                    return Line.Draw();
            }
            throw new InvalidShapeException(string.Format(Resources.app_InvalidShapeExceptionMessage, "unknown"));
        }

        public class Box
        {
            public static string Draw()
            {
                return Resources.app_DrawingABox;
            }
        }

        public class Circle
        {
            public static string Draw()
            {
                return Resources.app_DrawingACircle;
            }
        }

        public class Line
        {
            public static string Draw()
            {
                return Resources.app_DrawingALine;
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