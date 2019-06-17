using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectForCollections
{
    public class CollSortedList
    {
        public void SortedListMethod()
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }

            //Get a collection of the keys 
            ICollection keys = sl.Keys;

            foreach (string key in keys)
            {
                Console.WriteLine(key + ": " + sl[key]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Capacity Of Sorted List: {0}", sl.Capacity);
            Console.WriteLine("Actual Count Of Sorted List: {0}", sl.Count);
        }
    }
}
