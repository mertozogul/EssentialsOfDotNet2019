using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
   /* sealed abstract class Shape --> gives  'asbtract class canot be declared as sealed or static' compile error.. */
    abstract class Shape
    {
        public abstract int area();

        /* we can make virtual function implementation in abstract class. */
        public virtual int test()
        {
            return 456546;
        }
    }
}
