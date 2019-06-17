using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInheritence
{
    public class ClassCaller
    {
        /*
            Inheritance provides an opportunity to reuse the code functionality and  speeds up implementation time : Miras Alma kod fonksiyonelliğinin  tekrardan kullanılmasını  ve implementation süresinin hızlanmasını kısalmasına fırsat verir.  
        
            The idea of inheritance implements the IS-A relationship. For example, mammal IS A animal, dog IS-A mammal hence dog IS-A animal as well, and so on : Miras alma düşüncesi
              IS-A ilişkisini uygular. Örnek olarak memeliler is-a hayvandır. köpek is-a memelidir. Öyleyse köpek is-a hayvandır.
              Hayvan base class. Hayvandan Memeli classı Memelid en de Köpek classı türedi.

              Köpek : Memeli

              Memeli : Hayvanlar

            Dolayısıyla Köpek classı en deriveddır, ve memeli ve hayvanların  classların bütün üyelerine sahiptir, içerir.
           
            Multiple Inheritence In C#: 

            *****C# does not support multiple inheritance: C# çoklu miras almayı desteklemez. 
            * However, you can use interfaces to implement multiple inheritance : Ancak sen çoklu miras almayı desteklemek için interfaceleri kullanabilirsin. 
             **yani interfaceler c# da çoklu miras almayı da sağlıyor.
       */
        public static void Main(string[] args)
        {
            Console.WriteLine("Inheritance In Object Oriented Programming.");
            /*
               derived class both use own and base class's  methods and data.
            */
            //create derived class object
            Rectangle Rect = new Rectangle();

            //use base class (shape) members.
            //set data members
            Rect.setWidth(5);
            Rect.setHeight(7);

            //use derived class (rectangle) members
            Console.WriteLine("Total area: {0}", Rect.getArea());

            Console.WriteLine("---------");

            //assign data to the base class members with derived class's constructor. 
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();

            Console.WriteLine("-----Multiple Inheritance With Interface----");

            Rectangle rectObj = new Rectangle();
            int area;
            rectObj.setHeight(5);
            rectObj.setWidth(7);
            area = rectObj.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", area);
            // Print the cost of the area.
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
            
            Console.ReadKey();
        }
    }
}
