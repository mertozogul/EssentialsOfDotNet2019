using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForAttributes
{
    /// <summary>
    /// bir sonraki chapterda bu class da tanımlanan custom attribute'un sakladığı bilgileri reflection objeleri ile retrieve edicez.
    /// </summary>
    [DeBugInfo(45, "Devloper Name", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Diff Devloper Name", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        
        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w; 
        }

        [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]

        public double GetArea()
        {
            return length * width;
        }

        [DeBugInfo(56, "Zara Ali", "19/10/2012")]

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
