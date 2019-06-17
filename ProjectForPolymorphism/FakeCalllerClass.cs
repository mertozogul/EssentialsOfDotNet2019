using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class FakeCalllerClass
    {
        //Bu fonksiyona gelen parametre  rectangle da olabilir, triangle da olabilir, hangisini olcağı run time da belli olur. İşte BUNA DYNAMIC PLYMORPHISM DENİR.
        public void CallArea(ClassShape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}
