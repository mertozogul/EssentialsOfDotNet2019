using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class ClassShape
    {
        protected int width, height;

        public ClassShape(int w = 0, int h = 0)
        {
            width = w;
            height = h;
        }

        public virtual int area()
        {
            Console.WriteLine("Parent class area: ");
            return 0; 
        }
    }
}
