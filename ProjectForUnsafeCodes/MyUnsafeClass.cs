using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForUnsafeCodes
{
    public class MyUnsafeClass
    {
        public void FirstUnsafeMethod()
        {
            Console.WriteLine("-----------first unsafe example-----------");
            // Normal pointer to an object, a reference tipinde bir değişken, ve bellek bölgesinde sabit  
            //bir adresi göstermek zorunda. Dolayısıyla a yı bir pointer değişkenine  atıcaksan, fixed etmen gerekiyor pointerı, çünki pointer değişken adreslidir.  
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            unsafe
            {
                // Must pin object (p) on heap so that it (p) doesn't move while using interior pointers.
                fixed (int* p = &a[0])
                {
                    // p is pinned as well as object, so create another pointer to show incrementing it.
                    int* p2 = p;
                    Console.WriteLine(*p2); // 10
                    Console.WriteLine("first p2: {0}", (int)p2); //her seferinde sistem farklı adreslere değişkenleri depolar.  --> x int 32 bit yani 4 byte, yani diğer adres +4 artacak.
                    //Incrementing p2 bumps the pointer by four bytes due to its type ... 
                    p2 += 1;
                    Console.WriteLine("new p2: {0}", (int)p2);  // --> x + 4
                    Console.WriteLine(*p2); // 20
                    p2 += 1;
                    Console.WriteLine("new p2: {0}", (int)p2);  // --> x + 8
                    Console.WriteLine(*p2); //30

                    Console.WriteLine("--------");
                    Console.WriteLine(*p); // 10
                    // Dereferencing p and incrementing changes the value of a[0] ...
                    *p += 1;
                    Console.WriteLine(*p); // 11
                    *p += 1;
                    Console.WriteLine(*p); // 12
                }
            }
            Console.WriteLine("--------");
            Console.WriteLine(a[0]); // 12
            Console.WriteLine("-----------first unsafe example-----------");
        }

        public void SecondUnsafeMethod()
        {
            Console.WriteLine("-----------second unsafe example-----------");
            unsafe
            {
                int i_var = 20;
                int* i_ptr = &i_var;
                Console.WriteLine("Data is: {0}", i_var); // 20
                Console.WriteLine("Data is: {0}", *i_ptr); // 20
                Console.WriteLine("Data is: {0}", i_ptr->ToString());  // 20
                Console.WriteLine("Address is: {0}", (int)i_ptr); //i_var değişkenin değerinin tutulduğu bellek bölgesinin adresidir. proje her build  edildiğinde değişir.  
                Console.WriteLine("Address is: {0}", (int)&i_var);  //i_var değişkenin değerinin tutulduğu bellek bölgesinin adresidir. proje her build  edildiğinde değişir.  
            }
            Console.WriteLine("-----------second unsafe example-----------");
        }

        public void ThirdUnsafeMethod()
        {
            Console.WriteLine("-----------third unsafe example-----------");
            unsafe
            {
                int i_var1 = 10;
                int i_var2 = 20;
                int* i_ptr1 = &i_var1;
                int* i_ptr2 = &i_var2;
                Console.WriteLine("Before Swap: i_var1: {0}, i_var2: {1}", i_var1, i_var2);
                swap(i_ptr1, i_ptr2);
                Console.WriteLine("After Swap: i_var1: {0}, i_var2: {1}", i_var1, i_var2);
            }
            Console.WriteLine("-----------third unsafe example-----------");
        }

        public void FourthUnsafeMethod()
        {
            Console.WriteLine("-----------fourth unsafe example-----------");
            int[] list = { 10, 100, 200 };
            /*
                 array name reference type dır, elemanları value type olmasına rağmen. 
                 list reference tipi aslında array in ilk elemeanının adresidir. sen şimdi gidip o adresi pointera atıyorsun. pointerıda fixliyorsun.
                 list (array) ile pointer type değişkenin tek farkı list sabittir, amma pointer type değişken sabit değildir. 
                 bu yüzden array adını yani ilk adresine reference tipini pointer type'a atıcaksan, pointerı sabitliceksin.            
             */
            unsafe
            {
                fixed (int* ptr = list)  // fixed attiğin zaman list array değişkinini pointer ptr değişkenine atıyabilirsin. atama işlemi yatığına göre dizinin adı ile ile  pointer aynı tipte oluyor.
                //ama fixed etmez isen  array ile pointer değişkeni aynı tipte olmadığından array i pointera atıyamazsın. Array sabittir. pointer değişken.  
                //int* ptr = list; --> verilen compiler hatası --> CannotUnloadAppDomainException implicitly convert type 'int[]' to 'int*' --> görüldüğü gibi pointerı sabitlemez isen pointer ile array name aynı tipte değişken olmaz.
                //let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]: {1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]: {1}", i, (int)*(ptr + i));
                }
            }
            Console.WriteLine("-----------fourth unsafe example-----------");
        }

        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }

        public unsafe void ShowArrayElementAdressesOnMemory<T>(T[] arrayValues) where T : unmanaged
        {
            fixed (T* arrPtr = &arrayValues[0])
            {
                for (int i = 0; i < arrayValues.Length; i++)
                {
                    Console.WriteLine("{0}. array element address: {1}",i, (int)(arrPtr + i));
                }
            }  
        }
    }
}
