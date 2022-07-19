using System;

namespace OceanLib.CustomExceptions
{
    public class OceanNumException : Exception
    {
        public OceanNumException () : base("Invalid number of oceans.")
        {
        }

        public OceanNumException (string message) : base(message)
        {
        }

        public OceanNumException (string message, Exception inner) : base(message, inner)
        {
        }
    }
}
