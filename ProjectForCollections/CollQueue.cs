using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectForCollections
{
    public class CollQueue
    {
        public void QueueMethod()
        {
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.WriteLine("Current Queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");      
            }
            Console.WriteLine("");

            q.Enqueue('V');
            q.Enqueue('H');

            Console.WriteLine("Current Queue: ");
            foreach (char c in q)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
        }
    }
}
