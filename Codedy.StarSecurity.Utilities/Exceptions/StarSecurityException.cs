using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedy.StarSecurity.Utilities.Exceptions
{
    public class StarSecurityException : Exception
    {
        public StarSecurityException()
        {

        } 

        public StarSecurityException(string message) : base(message)
        {

        }

        public StarSecurityException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
