using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharpProject
{
    class BootcampException : Exception
    {
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
