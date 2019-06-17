using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInheritence
{
    //derived class
    //we can use multiple inheritence with interface in c#.
    public class Rectangle : Shape, ICost
    {
        public int getArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }
}
