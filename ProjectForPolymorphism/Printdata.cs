using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class Printdata
    {
        /* fonksyion aşırı yüklemesi yaptık. Aynı isimdeki fonksyionlara farklı işler yaptırdık. Argumen listesinde farklı tiplerde data input alarak. */
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
