using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPartialClasses
{
    /*
          Each class in C# resides in a separate physical file with a .cs extension. 
          C# provides the ability to have a single class implementation in multiple .cs files using the partial modifier keyword. 
          The partial modifier can be applied to a class, method, interface or structure.

        ---MyPartialClass in PartialClassFile1.cs defines constructor and one public method, Method1, whereas PartialClassFile2.cs has only one public method, Method2. 
        ---THE COMPILER COMBINES THESE TWO PARTIAL CLASSES INTO ONE CLASS AS BELOW: 
        **** --> Yani compiler aşağıdaki gibi tek class düşünür.
         public class MyPartialClass
            {
                public MyPartialClass()
                {
                }
        
                public void Method1(int val)
                {
                    Console.WriteLine(val);
                }

                public void Method2(int val)
                {
                    Console.WriteLine(val);
                }
            }
        *******
        Partial Class Requirements: --> PartialClass'ın kullanıldığı yerler.
        **All the partial class definitions must be in the same assembly and namespace. (Bütün partial class tanımlamaları aynı assembly ve namespace içerisinde yeralmak zorunda.)
        **All the parts must have the same accessibility like public or private, etc. (Bütün partial classlar atnı erişim belirtecine sahip olmak zorundadır. Ornek olarak public, private, protected, protected internal gibi, gibi..) 
        **If any part is declared abstract, sealed or base type then the whole class is declared of the same type. 
        **Different parts can have different base types and so the final class will inherit all the base types. (Farklı partial classlar farklı base classlardan miras alabilir.  Sonuç olrak compilerın gördüğü birleştirdiği son class butun base classlardan miras alır. ) 
        **The Partial modifier can only appear immediately before the keywords class, struct, or interface.
        
        Advantages of Partial Class: 
          **Multiple developers can work simultaneously with a single class in separate files. (Birden fazla developer eş zamanlı olarak tek class ayrı dosyalarda çalışabilir.)
          **
          **-->When working with automatically generated source, code can be added to the class without having to recreate the source file. For example, Visual Studio separates HTML code for the UI and server side code into two separate files: .aspx and .cs files.
          ** 
         --> Methodlarda classlar gibi partial olarak tanımlanabilir, implement  edilebilir.
         Partial Methodlar: 
            Partial classlar veya struct partial methodlar içerebilirler.  Partial method partial classların herhangi birinde bildirilmek zorundadır. Partial method kullanılacaksa eğer  
            partial classların herhangi birisinde bildirilmek zorundadırlar. 
            ****Partial methodların implementation ı  oladabilir olmayadabilir.
            Eğer partial method herhangi bir partial class da implementation'a sahip değil ise compiler final class da bu methodu generate etmez. Yani partial classlarda sadece declaration ı 
            olan partial methodları compiler final class da üretrmez.  Yani final class da bu method yokmuş gibi davranılır.
        Partial methodlar herhangi bir erişim belirteci içeremezler. abstract, virtual da olamazlar.  
        
        Requirements for Partial Method: 
          *The partial method declaration must began with the partial modifier.
          * The partial method can have a ref but not an out parameter. --> Partial Method ref paramater içerebilir fakat out tipinde parametre alamazlar.
          *Partial methods are implicitly private methods. Partial methodlar üstü kapalı olarak private tanımlanırlar. Yani aslında  privatedırlar. 
          *Partial methods can be static methods. (bu methodlar static olarak tanımlanabilirler.)
          *Partial methods can be generic. generic olarak da tanımlanabilirler. 
          * 
          * Yani derleyici Partial methodu final class'a taişırken private method olarak taşır. Yani derleyici parital methodu private olarak kabul eder.
          
        Points to Remember:
          --> Use the partial keyword to split interface, class, method or structure into multiple .cs files. Partial keywordunu interface, class, method veya structure ı çoklu .cs dosyalarına bölmek dağıtmak için kullan. 
          --> The partial method must be declared before implementation. Partial methodlar implementationdan önce bildirilmek zorundadırlar. Yani önce declaration sonra implementation olucak.
          --> All the partial class, method , interface or structs must have the same access modifiers. Bütün partial classlar, methodlar, interface'ler, structlar aynı erişim belirtecine sahip olmak zorundadırlar.
    */
    class ClassCaller
    {
        public static void Main(string[] args)
        {

            MyPartialClass obj = new MyPartialClass();
            //object kullanılarak partial methodlara erişemiyoruz. Çünki partial methodalr aslında privatedırlar.


            Console.WriteLine("hello partial classes.."); 
        }
    }
}
