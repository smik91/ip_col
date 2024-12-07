using ColloqWebAPI.BusinessLogic.Interfaces;
using ColloqWebAPI.Helpers;
using System.Numerics;

namespace ColloqWebAPI.BusinessLogic.Services
{
    public class FactorialCalculatorService : IFactorialCalculatorService
    {
        public BigInteger CalculateFactorial(int n)
        {
            InputValidator.ValidateFactorialInput(n);
            BigInteger result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
