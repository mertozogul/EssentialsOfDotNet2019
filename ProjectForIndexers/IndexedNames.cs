using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForIndexers
{
    public class IndexedNames
    {
        private string[] namelist = new string[size];
        static public int size = 10;
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        /// <summary>
        /// define first indexers to the class.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get {
                string tmp; 
                if(index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }

        /// <summary>
        /// overload preceding indexer with different return type and different parameter type. 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int this[string name]
        {
            get {
                int index = 0;
                while (index < size)
                {
                    if(namelist[index] == name)
                    {
                        return index; 
                    }
                    index++; 
                }
                return -1; 
            }
        }
    }
}
