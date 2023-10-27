namespace SmartKeys.Exceptions
{
    [Serializable]
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        { }

        public InvalidPasswordException(string message)
            : base(message)
        { }

        public InvalidPasswordException(Exception innerException, string message = "Invalid password")
            : base(message, innerException)
        { }
    }
}
