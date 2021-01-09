using CalculatorUI.Exceptions;
using System;
using System.Threading.Tasks;

namespace Calculator.MathOperations
{
    public class Divition : IMathOperation
    {
        public Task<decimal> Calculate(int[] numbers)
        {
            if (numbers[1] == 0)
            {
                throw new MathOperationException("Divition from 0 is not allowed.");
            }

            return Task.FromResult(Convert.ToDecimal(numbers[0] / numbers[1]));
        }
    }
}