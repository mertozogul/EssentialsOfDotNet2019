using System;
using System.Threading;

namespace ProjectForMultithreading
{
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Multithreading In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------first thread main thread example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //this is the main thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine("This is the {0}", mainThread.Name);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------thread class's properties examples---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Main Thread Current Culture Property Of Thread Class: {0}", mainThread.CurrentCulture);
            Console.WriteLine("Main Thread IsAlive Property Of Thread Class is used to show thread execution status. the Main Thread's Execution status Is:  {0}", mainThread.IsAlive);
            //main thread is not background thread, child threads are background thread. 
            Console.WriteLine("Thread Class IsBackground propery is used for show backgroun status of thread. Is The Maın Thread background thread: {0}", mainThread.IsBackground);
            //hangi threadler managed thread poolunun içerisinde bulunurlar. main thread e false döndü, child thread de dene, ikinci örnekte  
            Console.WriteLine("Is the main thread Pool thread {0}", mainThread.IsThreadPoolThread);
            Console.WriteLine("Main Thread ManagedthreadId: {0}", mainThread.ManagedThreadId);
            // Thread  class's Priority property is used for gets or sets value indicating the scheduling priority of a thread. 
            Console.WriteLine("Main Thread Priority: {0}", mainThread.Priority);
            // ThreadState attribute is used to show states of current thread.  
            Console.WriteLine("Main Thread State: {0}", mainThread.ThreadState);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------create child thread example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            //first create the delegate to call child thread method 
            ThreadStart childref_1 = new ThreadStart(SampleThreadExamples.ThreadFirstExample);
            //şu an threadin yaşam döngüsü başlamadı 
            Console.WriteLine("In Main: Creating the first child thread.");
            Thread childThread_1 = new Thread(childref_1);
            //şu an thredin yaşam döngüsü başladı. 
            childThread_1.Start();
            childThread_1.Abort();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------manage child thread example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            ThreadStart childref_2 = new ThreadStart(SampleThreadExamples.ThreadSecondExample);
            Console.WriteLine("In Main: Creating the second child thread for manage..");
            Thread childThread_2 = new Thread(childref_2);
            childThread_2.Start();
            childThread_2.Abort();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------Destroying Threads Example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            ThreadStart childref_3 = new ThreadStart(SampleThreadExamples.ThreadThirdExample);
            Console.WriteLine("In Main: Creating the Third Child thread");

            Thread childThread_3 = new Thread(childref_3);
            childThread_3.Start();

            //stop the main thread for some time
            Thread.Sleep(2000);

            //now abort the child
            Console.WriteLine("In Main: Aborting the Third Child thread");
            childThread_3.Abort();

            Console.ReadKey();
        }
    }
}