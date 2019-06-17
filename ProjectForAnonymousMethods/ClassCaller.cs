using System;

namespace ProjectForAnonymousMethods
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Anonymous Methods In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //create delegate instances using anonymous method
            NumberChanger nc = delegate (int x) {
                Console.WriteLine("Anonymous method : {0}", x);
            };

            //calling the delegate using the anonymous method 
            nc(100);

            //instantiating the delegate using the named methods 
            nc = new NumberChanger(ClassDelegate.AddNum);
            //calling the delegate using the named methods  
            nc(5);

            //instantiating the delegate using the other named methods 
            nc = new NumberChanger(ClassDelegate.MultNum);

            //calling the delegate using the named methods  
            nc(2);

            Console.ReadKey();
        }
    }
}
