using System;
using System.Collections.Generic;
using System.Text;
delegate int NumberChanger(int n);

namespace ProjectForDelegates
{
    public class TestDelegate
    {
       static int num = 10;
       int count = 10;
        public static int AddNum( int p )
        {
            num += p;
            return num;
        }

        public int AddCount(int p)
        {
            count += p;
            return count;
        }

        public static int MultNum( int q ) 
        {
            num *= q;
            return num;
        }

        public int MultCount(int q)
        {
            count *= q;
            return count;
        }

        public static  int GetNum()
        {
            return num;
        }

        public int GetCount()
        {
            return count;
        }

        public static  void ResetNum()
        {
            num = 10;
        }
    }
}
