﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharpProject
{
    class BootcampException : Exception
    {
        //For the empty class
        public BootcampException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public BootcampException(string message) : base(message)
        {

        }

        public BootcampException() : base()
        {

        }
    }
}
