using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class ClassRectangle : ClassShape
    {
        //virtual methodu override etmesende compile hatası vermez. 
        public ClassRectangle (int a = 0, int b = 0) : base (a, b) {}

        //override virtual function, abstract method override etmezsin çünki abstract methodun implementation u base class da yoktur. Bu yüzden üzerine yazmalık overridelık hewrhangi bir durum yoktur.

        public override int area()
        {
            Console.WriteLine("Rectangle Class Area: ");
            return width * height;
        }
    }
}
