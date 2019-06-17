using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForDataTypes
{
    public class ClassCaller
    {
        static void Main(string[] args)
        {
            int i = 100;
            String str = "String Reference Type Value In Main Method";
            DataTypes dt = new DataTypes();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("***************************");
            Console.WriteLine("However, value type field in a class can be declared without initialization (field not a local variable in the function) . It will have a default value if not assigned any value, e.g., int will have 0, boolean will have false and so on.");
            Console.WriteLine("dt.UseValueTypeFieldWithOutInitialize default value -->  {0}", dt.UseValueTypeFieldWithOutInitialize);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("***************************");
            Console.WriteLine("Value Data Types");
            Console.WriteLine("Int Value Type Data Before Change Function Is --> {0}  ", i);
            ChangeValueType(i);
            Console.WriteLine("Int Value Type Data After Change Function Is --> {0} ", i);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("***************************");
            Console.WriteLine("String Reference Data Types");
            Console.WriteLine("String Reference Type Data After Change Function Is --> {0}", str);
            ChangeStringReferenceType(ref str);
            Console.WriteLine("String Reference Type Data After Change Function Is --> {0}", str);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("***************************");
            Console.WriteLine("Class Reference Data Types");
            dt.SampleDataType = "Integer";
            Console.WriteLine("Data Type Is {0} In Main Method", dt.SampleDataType);
            ChangeClassReferenceType(dt);
            Console.WriteLine("Data Type Is {0} In Main Method", dt.SampleDataType);
        }

        public static void ChangeClassReferenceType(DataTypes dt)
        {
            dt.SampleDataType = "String";
            Console.WriteLine("Data Type Is {0} In Change Method", dt.SampleDataType);
        }

        public static void ChangeStringReferenceType(ref String str)
        {
            str = "Reference Type Value In Method";
            Console.WriteLine("Reference Type Data Is Changed In Change Method : Value In Method --> {0}", str);
        }  

        public static void ChangeValueType(int x)
        {
            x = 200;
            Console.WriteLine("Value  Type Data Is Changed In Change Method : Value In Method --> {0}", x);
        }


    }
}
