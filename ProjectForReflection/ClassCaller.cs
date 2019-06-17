using System;

namespace ProjectForReflection
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            //reflection objesi reflection classının memberinfo objesini create ederek MyClass üzerindei var olan run time atributelerini listeicez.
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Reflections In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);     
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------second example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();

            Type type = typeof(Rectangle);


            Console.WriteLine("...Rectangle Class Attributes...");
            //iterating through the attributes of the Rectangle Class  
            foreach (Object attr in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attr; 

                if(dbi != null)
                {
                    Console.WriteLine("Bug No: {0}", dbi.BugNo);
                    Console.WriteLine("Developer : {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            Console.WriteLine("...Rectangle Class's Method  Attributes...");
            foreach (System.Reflection.MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    DeBugInfo dbi_2 = (DeBugInfo)a; 
                    if(dbi_2 != null)
                    {
                        Console.WriteLine("Bug No: {0}, for Method: {1}", dbi_2.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi_2.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi_2.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi_2.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
