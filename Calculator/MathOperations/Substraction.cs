using System;
using System.Threading.Tasks;

namespace Calculator.MathOperations
{
    public class Substraction : IMathOperation
    {
        public Task<decimal> Calculate(int[] numbers)
        {
            return Task.FromResult(Convert.ToDecimal(numbers[0] - numbers[1]));
        }
    }
}