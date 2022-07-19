using System;

namespace OceanLib.CustomExceptions
{
    public class InvalidValueForObjectsException : Exception
    {
        public InvalidValueForObjectsException () : base("The amount of participants cannot be negative or equal to zero.")
        {
        }

        public InvalidValueForObjectsException (string message) : base(message)
        {
        }

        public InvalidValueForObjectsException (string message, Exception inner) : base(message, inner)
        {
        }
    }
}
