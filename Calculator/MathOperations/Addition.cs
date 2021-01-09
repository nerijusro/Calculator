namespace Calculator.MathOperations
{
    public class Addition : IMathOperation
    {
        public decimal Calculate(int[] numbers)
        {
            return numbers[0] + numbers[1];
        }
    }
}