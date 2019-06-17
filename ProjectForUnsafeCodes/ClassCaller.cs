using System;

namespace ProjectForUnsafeCodes
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Unsafe Codes && Data Types In C#..");

            int i_var = new int();
            //Console.WriteLine(i_var); C# 'ın eski versiyonlarında olsaydı, value type a value atamadan kullanamazdık, compiler hata verirdi.
            double d_var = new double();
            long l_var = new long();
            string s_var = new string("Reference Type Variable Orjinal Value");
            i_var = 222;
            //i_var = null; //int değişkene null değer atıyamazsın, value type bellekte valu tuttuğundan dolayı bir değer bekler. 
            //C# 2.0 dan itibaren nullable value tiplere imkan sağlandı. Reference tipler null değer e atanabilirler. Çünki bellekte değeri 
            //tutmazlar, null olduklarında bunun anlamı bellekte değer içeren herhangi bir adresi göstermediğidir. Bu yüzden null atanabilir reference tiplerine.
            d_var = 22222;
            l_var = (long)(i_var + d_var);
            MyClass myObj = new MyClass();
            MyUnsafeClass myUnsafeObj = new MyUnsafeClass();
            Student std1 = new Student();
            std1.StudentName = "Bill";

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example (data-types)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Int variable value is {0} before passing to the method.", i_var);
            myObj.ChangeValue(i_var);
            Console.WriteLine("Int variable value is {0} after passing to the method.", i_var);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------second example (data-types)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Reference Type Variable value is {0} before passing to the method.", std1.StudentName);
            myObj.ChangeReferenceType(std1);
            Console.WriteLine("Reference Type Variable value is {0} after passing to the method.", std1.StudentName);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------third example (data-types)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("before passing to the method as parameter: {0}", s_var);
            //string reference tipini 'ref' keywordu ile geçirmeseydik aynı value type gibi davranırddı. Değeri sadece methodun içerisinde değişirdi.  
            myObj.ChangeStringReferenceTypeVariableValue(ref s_var);
            Console.WriteLine("after passing to the method as parameter: {0}", s_var);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------fourth example (unsafe codes)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            myUnsafeObj.FirstUnsafeMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------fifth example (unsafe codes)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            // show array memory adresses intervals
            Console.WriteLine("int array addresses.."); // int 32 bit, 4 byte 
            int[] firstArr = new int[5] { 10, 20, 30, 40, 50 };
            myUnsafeObj.ShowArrayElementAdressesOnMemory<int>(firstArr);
            Console.WriteLine("char array addresses..");
            char[] secondArr = new char[5] { 'a', 'b', 'c', 'd', 'e' }; // char 16 bit, 2 byte
            myUnsafeObj.ShowArrayElementAdressesOnMemory<char>(secondArr);
            Console.WriteLine("double array addresses..");
            double[] thirdArr = new double[5] { 2340.0, 4523.69, 3421.0, 3428.0, 3429.0 }; // 64 bit, 8 byte
            myUnsafeObj.ShowArrayElementAdressesOnMemory<double>(thirdArr);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------sixth example (unsafe codes)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            myUnsafeObj.SecondUnsafeMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------seventh example (unsafe codes)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            myUnsafeObj.ThirdUnsafeMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------eighth example (unsafe codes)---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            myUnsafeObj.FourthUnsafeMethod();

            Console.ReadKey();
        }
    }
}
