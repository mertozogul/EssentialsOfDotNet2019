using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInheritence
{
    //Base Class 
    public class Shape
    {
        //data
        //aynı pakette public den farkı yok. Fakat başka paketllerde sadece bu classdan türeyen classlardan bu yelere erişim olur.
        //classlar  ve interface ler protected olarak tanımlanamazlar.
        protected int width;
        protected int height;

        //methods
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
    }
}
