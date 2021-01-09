using System.Threading.Tasks;

namespace Calculator
{
    public interface IMathOperation
    {
        Task<decimal> Calculate(int[] numbers);
    }
}