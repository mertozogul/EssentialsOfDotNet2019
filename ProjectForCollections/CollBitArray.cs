using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectForCollections
{
    public class CollBitArray
    {
        public void BitArrayMethod()
        {
            /*
              0: false 1: true             
              xxxx xxxx
            2^0123 4567
              60 :  0011 1100
              13 :  1011 0000
              60 or 13: 1011 1100 --> 61
              60 and 13: 0011 0000 --> 12
            */

            //creating two bit arrays  of size  8 
            // 1 byte --> 8 bit, dizideki bit değerleri boolean değerler ile temsil edilir. 1: true 0: false
            // 1 integer --> 32 bit int değeride bit dizisi şeklinde gösterebiliriz.
            //BitArray ba1 = new BitArray(8);  //8 bitlik bit dizisi, bu dizinin her bir bitinin default değeri false dur yani 0 dır.  
            //BitArray ba2 = new BitArray(8);

            byte[] a = { 60 };
            byte[] b = { 13 };
            int[]  c = { 99 };

            BitArray ba1 = new BitArray(a);
            BitArray ba2 = new BitArray(b);
            
            //ba1 ile ba2 bit dizilerini or işleminde kullanıcaksan ba1 ve ba2 nin bit sayısı aynı olmak zorunda.
            BitArray ba3 = new BitArray(ba1.And(ba2));

            //reset ba1 and ba2  
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            BitArray ba4 = new BitArray(ba1.Or(ba2));

            //reset ba1 and ba2  
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);

            BitArray bai = new BitArray(c);

            //content of ba1
            Console.WriteLine("length of bit array ba1: {0}", ba1.Length);
            Console.WriteLine("Bit array represent byte value. Bit array ba1: 60");
            for (int i = 0; i < ba1.Length; i++)
            {
                Console.Write("{0, -6}",  ba1[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("");

            //content of ba2  
            Console.WriteLine("length of bit array ba2: {0}", ba2.Length);
            Console.WriteLine("Bit array represent byte value.Bit array ba2: 13");
            for (int i = 0; i < ba2.Length; i++)
            {
                Console.Write("{0, -6}", ba2[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("==========================");

            //content of ba3
            Console.WriteLine("length of bit array ba3: {0}", ba3.Length);
            Console.WriteLine("ba1 and ba2: 12");
            for (int i = 0; i < ba3.Length; i++)
            {
                Console.Write("{0, -6}", ba3[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("==========================");

            //content of ba4
            Console.WriteLine("length of bit array ba4: {0}", ba4.Length);
            Console.WriteLine("ba1 or ba2: 61");
            for (int i = 0; i < ba4.Length; i++)
            {
                Console.Write("{0, -6}", ba4[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("==========================");

            //content of bai  
            Console.WriteLine("length of bit array bai: {0}", bai.Length);
            Console.WriteLine("Bit array represent int value.int has 32 bit. Bit array bai: 99");
            for (int i = 0; i < bai.Length; i++)
            {
                Console.Write("{0, -6}", bai[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("");
        }
    }
}
