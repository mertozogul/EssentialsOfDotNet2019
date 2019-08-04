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


        //we must meke method definition for virtual methods
        //public virtual int testrt();

        //we dont't have to override virtual methods because it has method definition. 
        //we have to override abstract methods because it has not method definiyion in base class. 
    }
}
