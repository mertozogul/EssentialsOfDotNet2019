using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectForCollections
{
    public class CollStack
    {
        public void StackMethod()
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current Stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("");

            st.Push('V');
            st.Push('H');

            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());

            Console.WriteLine("Current Stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current Stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }
    }
}
