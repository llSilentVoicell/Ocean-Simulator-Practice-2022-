using System;

namespace OceanLib.CustomExceptions
{
    public class InvalidColumnsValueException : Exception
    {
        public InvalidColumnsValueException() : base("Invalid value for the number of columns.")
        {
        }

        public InvalidColumnsValueException(string message) : base(message)
        {
        }

        public InvalidColumnsValueException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
