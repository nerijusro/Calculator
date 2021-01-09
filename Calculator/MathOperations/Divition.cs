namespace Calculator.MathOperations
{
    public class Divition : IMathOperation
    {
        public decimal Calculate(int[] numbers)
        {
            return numbers[0] - numbers[1];
        }
    }
}