using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class ClassTriangle : ClassShape
    {
        public ClassTriangle (int a = 0, int b = 0) : base(a, b) { }

        public override int area()
        {
            Console.WriteLine("Triangle Class Area");
            return (width * height) / 2;
        }
    }
}
