using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStaticTypes
{
    public class MyNonStaticClass
    {
        /*
           A static or non-static class can have a static constructor without any access modifiers like public, private, protected, etc.
           A static constructor in a non-static class runs only once when the class is instantiated for the first time.
        */
       
        static MyNonStaticClass()
        {
            Console.WriteLine("Inside static constructor which is in non-static class.");
        }



        /*static*/
        private static int myStaticVariable = 0;
        public static void MyStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        /*nonstatic*/
        private int myNonStaticVariable = 0;
        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }
}
