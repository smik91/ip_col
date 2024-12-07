namespace ColloqWebAPI.Exceptions
{
    public class NegativeInputException : Exception
    {
        public NegativeInputException(string message) : base(message) { }
    }
}
