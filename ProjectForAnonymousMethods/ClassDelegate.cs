using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForAnonymousMethods
{
    delegate void NumberChanger(int n);
    delegate T GenericNumberChanger<T>(T n);     
    public class ClassDelegate
    {
        public static int num = 10;

        public  static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method AddNum: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method MultNum: {0}", num);
        }

        public static int GetNum()
        {
            //'this' keyword can't used in static method..
            return num; 
        }
    }
}
