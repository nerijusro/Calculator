using System;

namespace CalculatorUI.Exceptions
{
    public class MathOperationException : Exception
    {
        public MathOperationException()
        {

        }

        public MathOperationException(string message) : base(message)
        {

        }
    }
}
