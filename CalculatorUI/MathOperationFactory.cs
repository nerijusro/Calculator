using Calculator;
using Calculator.MathOperations;

namespace CalculatorUI
{
    public class MathOperationFactory
    {
        public static IMathOperation GetMathOperation(string operationKey)
        {
            IMathOperation operation;

            switch (operationKey)
            {
                case "+":
                    operation = new Addition();
                    break;
                case "-":
                    operation = new Substraction();
                    break;
                case "*":
                    operation = new Multiplication();
                    break;
                case "/":
                    operation = new Divition();
                    break;
                case "fib":
                    operation = new GetFibonacci();
                    break;
                default:
                    operation = null;
                    break;
            }

            return operation;
        }
    }
}
