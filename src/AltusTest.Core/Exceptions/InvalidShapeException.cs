using System;

namespace AltusTest.Core.Exceptions
{
    public class InvalidShapeException : Exception
    {
        public InvalidShapeException(string message) : base (message)
        {
        }
    }
}