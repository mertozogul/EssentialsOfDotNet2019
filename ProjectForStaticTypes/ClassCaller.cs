using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStaticTypes
{
    public class ClassCaller
    {
         static void Main(string[] args)
        {
            /*
                 Tips: 
                 1--> Class adıyla sadece static üyelere erişim sağlarız. Class ister statik ister non-static olsun onun içerisindeki static üyelere class adıyla erişilebilir. 
                 2--> Diyelim static olmayan  bir classın nesnesini oluşturdunuz. Bu nesne ile bu classın sadece static olmayan üyelerine erişim sağlıyabilirsiniz.Bu nesne non-static classın içerisindeki static üyeleri
                      göremez. Static üyelere her zaman class adıyla erişilebilir.
                 3--> Class eğer static ise onu örneklendiremezsin.
                 4--> Static classın içerisinde sadece static üyelere izin verilir. 
                 5--> Static olmayan bir classın içerisinde hem static  hem non-static üyelere izin verilir. Static olmayan classın doğrudan adıyla static üyelere erişilir, Static olmayan classın objecti ile static
                      olmayan üyelere erişim sağlanır.
             */

            /*
              Points to Remember:
                *Static classes cannot be instantiated using the new keyword
                *Static items share the resources between multiple users.
                *Static cannot be used with indexers, destructors or types other than classes.
                *A static constructor in a non-static class runs only once when the class is instantiated for the first time.
                *A static constructor in a static class runs only once when any of its static members accessed for the first time.
                *All static members are allocated in high frequency heap area of the memory.
            */

            NonStaticClass obj = new NonStaticClass();
            //MyStaticClass obj1 = new MyStaticClass(); --> gave buil error.
            
            /*(static constrauctors runs once when static members was accessed for the first time.) Static constructors in static class (or non-static class) run once although  the static members was accessed multiple times*/
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
