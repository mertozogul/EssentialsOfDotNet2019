using System;
using System.Collections.Generic;
using System.Text;

delegate T NumberChanger<T>(T n); 

namespace ProjectForGenerics
{
    public class MyGenericDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
}
