using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPartialClasses
{
    public partial class MyPartialClass
    {
        /* constructor */
       public MyPartialClass() { }

        /* declaration of partial method */
       partial void PartialMethod(int val);

        /* declaration of partial method */
        partial void PartialMethodWithRefParam(ref int val);

        /*
           partial methodlar out tipinde paramatreler alamazlar. 
           partial void PartialMethodWithOutParam(out int val);
        */

        public void  Method1(int val)
       {
            Console.WriteLine(val);
       }
    }
}
