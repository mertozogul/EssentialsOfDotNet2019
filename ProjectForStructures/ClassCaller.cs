using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStructures
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Structures In C#...");
            Console.WriteLine("");
            Console.WriteLine("");

            Books Book1 = new Books();   /* Declare Book1 of type Book */
            Books Book2 = new Books();   /* Declare Book2 of type Book */

            /* book 1 specification */
            Book1.setValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 specification */
            Book2.setValues("Telecom Billing",
            "Zara Ali", "Telecom Billing Tutorial", 999999);

            Console.WriteLine("Book1 of type Book Infos: ");
            /* print Book1 info */
            Book1.display();

            Console.WriteLine("***********************");

            Console.WriteLine("Book2 of type Book Infos: ");
            /* print Book2 info */
            Book2.display();

            Console.ReadKey();
        }
    }
}
