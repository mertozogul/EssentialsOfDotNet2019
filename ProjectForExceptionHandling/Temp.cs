using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForExceptionHandling
{
    public class Temp
    {
        int temp;

        public void ShowTemp()
        {
            if (temp == 0)
            {
                throw (new MyCustomExceptionClass("This Error Message Is Thrown Only With Using Any Exception Class(Predefined Or Custom)... "));
                //throw (new DivideByZeroException("This Error Message Is Thrown Only With Using Any Exception Class(Predefined Or Custom)... "));
                //throw (new Exception("This Error Message Is Thrown Only With Using Any Exception Class(Predefined Or Custom)... "));
            }
            else
            {
                Console.WriteLine("Temp: {0}", temp);
            }
        }
    }
}
