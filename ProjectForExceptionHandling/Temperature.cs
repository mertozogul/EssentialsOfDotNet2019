using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForExceptionHandling
{
    public class Temperature
    {
        int temp;

        public void ShowTemp()
        {
            if (temp == 0)
            {
               // throw new Exception("sdfgsdgsd");
                throw (new MyCustomExceptionClass("Zero Temp Found...This Error Message thrown with my own exception class..."));
            }
            else
            {
                Console.WriteLine("Temp: {0}", temp);
            }
        }
    }
}
