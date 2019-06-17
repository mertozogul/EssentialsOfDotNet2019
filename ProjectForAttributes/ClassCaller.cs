using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForAttributes
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Attributes In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Myclass.Message_2("This text is shown in all mode.");
            Myclass.Message("In Main function.");
            function1();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //OldMethod();



            Console.ReadKey();
        }


        //Using this method is error because it is defined as obsolete. 
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }

        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        static void function1()
        {
            Myclass.Message("In Function 1");
            function2();
        }

        static void function2()
        {
            Myclass.Message("In Function 2");
        }
    }

    public class Myclass
    {
        /*
           This predefined attribute marks a conditional method whose 
           execution depends on a specified preprocessing identifier.  
       */
        [Conditional("DEBUG")]

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }


        public static void Message_2(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
