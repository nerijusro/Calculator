﻿namespace Calculator.MathOperations
{
    public class GetFibonacci : IMathOperation
    {
        public decimal Calculate(int[] numbers)
        {
            var nMinus2 = 0;
            var nMinus1 = 1;
            var n = 0;

            for (int i = 2; i < numbers[0]; i++)
            {
                n = nMinus1 + nMinus2;
                nMinus2 = nMinus1;
                nMinus1 = n;
            }

            return n;
        }
    }
}