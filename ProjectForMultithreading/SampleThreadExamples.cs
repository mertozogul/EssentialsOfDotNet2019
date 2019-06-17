using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectForMultithreading
{
    public class SampleThreadExamples
    {
        public static void ThreadFirstExample()
        {
            Console.WriteLine("First Child thread starts");
        }

        public static void ThreadSecondExample()
        {
            Console.WriteLine("Second Child thread starts");

            //the thread is paused for 5000 milliseconds 
            int sleepfor = 5000;
            Console.WriteLine("Second Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);

            Console.WriteLine("Second Child thread resumes.");
        }

        public static void ThreadThirdExample()
        {
            try
            {
                Console.WriteLine("Third Child thread starts");

                Thread curChildThread = Thread.CurrentThread; //bu methodun içerisindeki currentthread dedğinde bu fonksyionu icra edern child thread reference edilmiş olur.
                // Thread class's properties..
                Console.WriteLine("Is The Third Child thread backgound: {0}.", curChildThread.IsBackground);
                Console.WriteLine("Is the third child thread Pool thread {0}", curChildThread.IsThreadPoolThread);
                Console.WriteLine("third Child Thread ManagedthreadId: {0}", curChildThread.ManagedThreadId);


                // do some work, like counting to 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("third Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {
                //this exception c an not be caught so that control go to the finally block. 
                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }
    }
}