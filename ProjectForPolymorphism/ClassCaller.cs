using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPolymorphism
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism In C#..");

            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);

            //burada static early binding vardır. Bu yüzden static polymorphism olarak adlandırılır. Early binding de sen methodu hangi aşırı yüklenmiş methodu çağırdığın bellidir compile time da. Derleyici compile time'da 
            //object bind olmuş methodun hangi method olduğunu compile time da bilir. Bu yüzden early binding dir.
            // Call print to print float
            p.print(500.263);

            // Call print to print string
            p.print("Hello C++");

            Console.WriteLine("*****Dynamic Polymorphism (Run Time Polymorphism / Late Binding / Dynamic Binding)*****");

            Rectangle r = new Rectangle(10, 7);
            //küçük bir değeri büyük bir değere assign edebiiyorz. Implicit Conversion. 
            double a = r.area();
            Console.WriteLine("Area: {0}", a);

            Console.WriteLine("Dynamic Polymorphism With Virtual Functions");
            FakeCalllerClass c = new FakeCalllerClass();
            //bunun methoduna parametre vericez. Ya rectangle yada traingle class paramatre oalrak verebiliriz. ClassShape parametre alıyor ama, biz buna hem classrectangle hemde classTriangle objecti parametre
            //olarak verebiiriz. Çünki classtriangle ve classrectangle classları classshape den türemiştir. Bu fonksiyon a hangi classın gideceği compile time 'da belli değildir, run time da belli olur.

           ClassRectangle c_r = new ClassRectangle(10, 7); //dikdörtgen alan --> 70 
           ClassTriangle c_t = new ClassTriangle(10, 5); // --> üçgen alan -->  25

            c.CallArea(c_r);
            c.CallArea(c_t);

            Console.ReadKey();
        }
    }
}
