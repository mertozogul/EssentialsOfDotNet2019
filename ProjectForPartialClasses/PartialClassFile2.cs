using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPartialClasses
{
    public partial class MyPartialClass
    {
        public void Method2(int val)
        {
            Console.WriteLine(val);
        }

        /* Implementation Of The  Partial Method  */
        partial void PartialMethod(int val)
        {
            Console.WriteLine(val);
        }

        /* Implementation Of The  Partial Method  */
        partial void PartialMethodWithRefParam(ref int val)
        {
            Console.WriteLine(val);
        }

        /*
         * Declaration ı yapılmayan partial method implement edilemez.
            partial void PartialMethodWithOutDeclaration(int val)
            {
                Console.WriteLine(val);
            }
        */
    }
}
