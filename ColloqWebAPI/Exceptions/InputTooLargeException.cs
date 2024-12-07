namespace ColloqWebAPI.Exceptions
{
    public class InputTooLargeException : Exception
    {
        public InputTooLargeException(string message) : base(message) { }
    }
}
