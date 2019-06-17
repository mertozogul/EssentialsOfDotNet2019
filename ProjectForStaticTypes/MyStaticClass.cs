using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStaticTypes
{
    public static class MyStaticClass
    {
        /*
            1--> We can declare static members in both static class and non-static class
            2--> We can not declare non-static members in static class.  neden ? çünki non-static üyelere classın nesnesi  ile erişebilirsin. Static classında örneği, nesnesi oluşturulamaz. Dolayısıyla non-static 
                 üyeler static classların içerisinde olamazlar. 
        */
        /*
              A static or non-static class can have a static constructor without any access modifiers like public, private, protected, etc.
              A static constructor in a static class runs only once when any of its static members accessed for the first time.
        */

        static MyStaticClass()
        {
            Console.WriteLine("Inside static constructor which is in static class.");
        }

        /*
         * we can not declare non static members in static class. 
                int sdsad = 0;

                public void testmethod()
                {

                }         
        */

        /*Static Members*/
        public static int myStaticVariable = 0;
        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
        public static int MyStaticProperty { get; set; }
    }

    public class NonStaticClass
    {
        /*
            1--> We can declare static members in both static class and non-static class 
        */
        /*Static Members*/
        public static int myStaticVariable = 0;
        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
        public static int MyStaticProperty { get; set; }
        
        /*
              1--> Tips: We can not declare non-static members in static class
        */
        /*Non-Static Members*/
        public int myNonStaticVariable = 0;
        public void MyNonStaticMethod()
        {
            Console.WriteLine("This is a non-static method.");
        }
        public int MyNonStaticProperty { get; set; }
    }
}
