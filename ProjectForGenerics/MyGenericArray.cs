using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForGenerics
{
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1]; 
        }

        public T getItem(int Index)
        {
            return array[Index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
