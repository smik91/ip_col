using System.Numerics;

namespace ColloqWebAPI.BusinessLogic.Interfaces
{
    public interface IFactorialCalculatorService
    {
        BigInteger CalculateFactorial(int n);
    }
}
