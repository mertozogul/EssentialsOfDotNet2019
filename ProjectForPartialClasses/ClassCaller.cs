using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPartialClasses
{
    class ClassCaller
    {
        public static void Main(string[] args)
        {

            MyPartialClass obj = new MyPartialClass();
            //object kullanılarak partial methodlara erişemiyoruz. Çünki partial methodalr aslında privatedırlar.


            Console.WriteLine("hello partial classes.."); 
        }
    }
}
