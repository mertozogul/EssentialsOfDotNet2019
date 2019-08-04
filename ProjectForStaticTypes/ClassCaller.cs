using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStaticTypes
{
    public class ClassCaller
    {
         public static void Main(string[] args)
         {
            NonStaticClass obj = new NonStaticClass();
            //MyStaticClass obj1 = new MyStaticClass(); --> gave buil error.
            
            /*(static constructors runs once when static members was accessed for the first time.) Static constructors in static class (or non-static class) run once although  the static members was accessed multiple times*/
            MyStaticClass.myStaticVariable = 100;

            MyStaticClass.MyStaticProperty = 200;

            MyStaticClass.myStaticVariable = 300;

            MyStaticClass.MyStaticProperty = 400;


            MyStaticClass.MyStaticMethod();

            MyStaticClass.MyStaticProperty = 100;

            Console.WriteLine("static class static property " + MyStaticClass.MyStaticProperty);

            Console.WriteLine("****Attention****");

            /*
                  In the below codes , we instantiate MyNonStaticClass three times but the static constructor got called only once when it instantiated for the first time.
            */

            MyNonStaticClass mnsObj1 = new MyNonStaticClass();
            MyNonStaticClass mnsObj2 = new MyNonStaticClass();
            MyNonStaticClass mnsObj3 = new MyNonStaticClass();
         }

        public static void NonStaticMethod()
        {
            int x = 100;
            NonStaticClass obj = new NonStaticClass();
            
        } 

        void MyNonStaticMethod()
        {
            NonStaticClass obj = new NonStaticClass();
            NonStaticClass.MyStaticProperty = 100;
            /*
              obj.
               Non-Static değişkenlere hem static hem de static olmayan methodlardan erişebiliyoruz.
             */
            /*
               MyNonStaticClass.
               Static üyelerede hem static hemde static olmayan methodlardan erişebiliyoruz. 
             */
        }
    }
}
