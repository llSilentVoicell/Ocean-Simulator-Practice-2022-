using System;

namespace OceanLib.CustomExceptions
{
    public class OceanOverflowException : Exception
    {
        public OceanOverflowException () : base("The number of objects exceeds the size of the ocean.")
        {
        }

        public OceanOverflowException (string message) : base(message)
        {
        }

        public OceanOverflowException (string message, Exception inner) : base(message, inner)
        {
        }
    }
}
