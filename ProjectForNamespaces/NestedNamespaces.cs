using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  parent_namespace
{
    class xyz
    {
        public void func()
        {
            Console.WriteLine("Inside parent namespace...");
        }
    }

    namespace child_namespace
    {
        class wwww
        {
            public void func()
            {
                Console.WriteLine("Inside child namespace...");
            }
        }
    }
}