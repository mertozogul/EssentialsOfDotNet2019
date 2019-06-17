using System;

namespace ProjectForIndexers
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Indexers In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            IndexedNames names = new IndexedNames();

            //we will use the class object as virtual array with indexers which are defined in it. 
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";

            //using the first indexer with int parameter
            for (int i = 0; i < IndexedNames.size; i++)
            {
                //use class object like as array.
                Console.WriteLine(names[i]);
            }

            //using the second indexer with the string parameter
            Console.WriteLine(names["Nuha"]);
            Console.WriteLine(names["Mert"]); //it will return -1. not found error :)

            Console.ReadKey();
        }
    }
}
