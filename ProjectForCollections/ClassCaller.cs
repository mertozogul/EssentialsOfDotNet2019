using System;

namespace ProjectForCollections
{
    public class ClassCaller
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hello Collections In C#..");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------arraylist class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollArrayList objArrayList = new CollArrayList();
            objArrayList.ArrayListMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------hashtable class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollHashTable objHashTable = new CollHashTable();
            objHashTable.HashTableMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------sortedlist class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollSortedList objSortedList = new CollSortedList();
            objSortedList.SortedListMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------stack class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollStack objStack = new CollStack();
            objStack.StackMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------queue class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollQueue objQueue = new CollQueue();
            objQueue.QueueMethod();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------bitarray class example---------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            CollBitArray objBitArray = new CollBitArray();
            objBitArray.BitArrayMethod();

            Console.ReadKey();
        }
    }
}
