﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForGenerics
{
    public class MyGenericMethod
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp; 
        }
    }
}
