using System;

namespace ProjectForProperties
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Properties In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //Create a new Student Object 
            Stdnt s = new Stdnt();

            // Setting code, name and the age of the student 
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s.ToString());

            //let us increase age 
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s.ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------second example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            //Create a new Student object: 
            Student classObj = new Student();

            //Setting code, name and the age of the student
            classObj.Code = "001";
            classObj.Name = "Nuha";
            classObj.Age = 9;

            Console.WriteLine("Student Info: - {0}", classObj);

            //let us increase age 
            classObj.Age = 10;
            Console.WriteLine("Student Info: - {0}", classObj);


            Console.ReadKey();
        }
    }
}
