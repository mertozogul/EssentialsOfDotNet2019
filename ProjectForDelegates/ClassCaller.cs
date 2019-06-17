using System;

namespace ProjectForDelegates
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Delegates In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            TestDelegate obj = new TestDelegate();
            PrintString classObj = new PrintString();


            //create delegate instances
            NumberChanger nc1 = new NumberChanger(TestDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(TestDelegate.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", TestDelegate.GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", TestDelegate.GetNum());

            //call methods with non-static field:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("With Non-Static Fields");
            Console.WriteLine("");
            Console.WriteLine("");

            //create delegate instances
            NumberChanger nc3 = new NumberChanger(obj.AddCount);
            NumberChanger nc4 = new NumberChanger(obj.MultCount);

            //calling the methods using the delegate objects
            nc3(25);
            Console.WriteLine("Value of Num: {0}", obj.GetCount());
            nc4(5);
            Console.WriteLine("Value of Num: {0}", obj.GetCount());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------second example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            TestDelegate.ResetNum();
            //create delegate instance:   
            NumberChanger nc;
            //using multicating property of delegates:
            nc = nc1;
            nc += nc2;
            //calling multicast
            nc(5); ///75
            Console.WriteLine("Value Of Num: {0}", TestDelegate.GetNum());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------third example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            printString ps1 = new printString(PrintString.PrintToScreen);
            printString ps2 = new printString(PrintString.WriteToFile);

            PrintString.sendString(ps1);
            PrintString.sendString(ps2);

            Console.ReadKey();
        }
    }
}
