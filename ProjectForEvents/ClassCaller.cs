using System;
public delegate string MyDel(string str);

namespace ProjectForEvents
{
    //ClassCaller class is publisher class  of event
    public class ClassCaller   //this class is publisher class. It publish defined event to the subscriber classes
    {
        public event MyDel MyEvent;

        public ClassCaller()
        {
            //delegate and event are associated. Delegate object is creeating with new keyword and added to the event. After that  when the event is thrown then  
            //WelcomeUser method is ran with using MyDel delagate. 
            this.MyEvent += new MyDel(Subscriber.WelcomeUser);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Events In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            ClassCaller cls = new ClassCaller();
            //A publisher class object invokes the event and it is notified to other objects. 
            //call event and then the event will called subscriber class's event handler method with  using delegate. 
            string result = cls.MyEvent("Tutorials Point");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
