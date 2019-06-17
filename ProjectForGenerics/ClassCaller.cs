using System;

namespace ProjectForGenerics
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Generics In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------using generic class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //declaring an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //setting values 
            for (int for_c = 0; for_c < 5; for_c++)
            {
                intArray.setItem(for_c, for_c * 5);
            }
            //retrieving the values 
            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.getItem(i) + " ");
            }
            Console.WriteLine("");

            //declaring a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //setting values 
            for (int j = 0; j < 5; j++)
            {
                charArray.setItem(j, (char)(j+97));
            }
            //retrieving the values 
            for (int m = 0; m < 5; m++)
            {
                Console.Write(charArray.getItem(m) + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------using generic method  example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            //display values  before swap: 
            Console.WriteLine("Int values before calling swap: ");
            Console.WriteLine("a = {0}, b = {1} ", a, b);
            Console.WriteLine("Char values before calling swap: ");
            Console.WriteLine("c = {0}, d = {1} ", c, d);

            //call swap
            MyGenericMethod.Swap<int>(ref a, ref b);
            MyGenericMethod.Swap<char>(ref c, ref d);

            //display values  after swap: 
            Console.WriteLine("Int values after calling swap: ");
            Console.WriteLine("a = {0}, b = {1} ", a, b);
            Console.WriteLine("Char values after calling swap: ");
            Console.WriteLine("c = {0}, d = {1} ", c, d);
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------using generic delegate example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //create delegate instances 
            NumberChanger<int> nc1 = new NumberChanger<int>(MyGenericDelegate.AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MyGenericDelegate.MultNum);

            //calling the methods using delagate instances or objects 
            nc1(25);
            Console.WriteLine("Value Of Num: {0}", MyGenericDelegate.getNum()); // 35

            nc2(5);
            Console.WriteLine("Value Of Num: {0}", MyGenericDelegate.getNum()); // 175 

            Console.ReadKey();
        }
    }
}
