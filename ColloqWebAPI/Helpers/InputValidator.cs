using ColloqWebAPI.Exceptions;

namespace ColloqWebAPI.Helpers
{
    public static class InputValidator
    {
        public static void ValidateFactorialInput(int n)
        {
            if (n < 0)
            {
                throw new NegativeInputException("Число не может быть отрицательным для вычисления факториала.");
            }

            if (n > 1000)
            {
                throw new InputTooLargeException("Входное число слишком велико.");
            }
        }
    }
}
