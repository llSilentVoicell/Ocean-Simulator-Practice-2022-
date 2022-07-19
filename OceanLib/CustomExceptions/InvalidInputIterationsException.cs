﻿using System;

namespace OceanLib.CustomExceptions
{
    public class InvalidInputIterationsException : Exception
    {
        public InvalidInputIterationsException () : base("The number of iterations cannot be negative or equal to zero. Also it cannot be exceed 1000.")
        {
        }

        public InvalidInputIterationsException (string message) : base(message)
        {
        }

        public InvalidInputIterationsException (string message, Exception inner) : base(message, inner)
        {
        }
    }
}
