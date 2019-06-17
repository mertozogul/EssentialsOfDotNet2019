using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForExceptionHandling
{
    public class MyCustomExceptionClass : Exception
    {
        public MyCustomExceptionClass(string message) : base(message)
        {

        }
    }
}
