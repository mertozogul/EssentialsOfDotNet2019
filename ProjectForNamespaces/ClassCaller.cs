using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fspace;
using sspace;

using parent_namespace;
//parent namespace'i using directive'i ile eklememe rağmen  child namespace'i de using directive i ile eklemem gerekicek. Parantı ekledim diye child otomotoik eklenicek diye bir konu yok. 
//childın memberlerine erişebilmek için parent haricinde child namespace inide using directivi ile eklemen gerekir. Aşağıdaki kod satırında olduğu gibi.. 
using parent_namespace.child_namespace;

namespace ProjectForNamespaces
{
    /*
     *  Bir namespace de tanımlanmış classlar diğer namespace tanımlanmış aynı isimli classlar ile çakışmazlar (yani conflict meydana gelmez, farklı isimli namespacelerden dolayı).
        The class names declared in one namespace does not conflict with the same class names declared in another.

        Using keyword:
       Using keyword'ü programın verilen namespace deki nameleri kullandığını belirtir.  Örnek olarak biz kendi programlarımızda System namespace'ini kullanıyoruz.
       Console class'ı 'System' namespace'inde tanımlıdır. 
       Biz sadece: 
             Console.Writline("Hello there");
         yazıyoruz. 
       Demekki Console static bir class. İçerisinde console ile ilgili methodlar barındırıyor. Direk class adıyla Writeline methodunu call ediyoruz. Writeline static Console classının içerisinde br methoddur. 
       static Console class'ı System namespace'inin içerisindedir. Tabii system namespace'inin  içerisinde Console classından başka classlarda mevcuttur.

        System namespace'i bir sürü namespaceler içerir. Bu namespaceler de kendine özgü classları ve methodları içerir.

        Örnek olarak: System --> System.Collections  --> System.Collections.Generic : bu namespaceler soldan sağa birbirlerini içerirler. en üst en büyük namespace System nmespece'idir. 
        sen using System ile programına system namespaci'ini ekliyebilirsin, fakat systemi eklememn linq namespaceinide ekliyor olduğun anlamına gelmez. 
        Linq namespace inin classlarındaki methodları kullanabilmek için using System.Linq diyerek linq namespace'ini programına eklemn gerekir.

        Biz methodları çağırırken tam adlarınıda kullanabiliriz. Şu şekilde: 
        System.Console.WriteLine("Hello there");
        bu methodu namespace --> class --> method name ile tam adını kullanarak da çağırabiliriz.

        Using namespace directive'ini kullanarak sen kodun içinde namespace namelerini namespace adını yazmadan call edebilirsin.
        Using namespace directive'i compiler'a bir sonraki kodun namespace içerisindeki nameleri kullanacağını söylüyor. 
        Böylece namespace bir sonraki koda uygulanmış oluyor. Bu şekşlde yazılımcı kodun içerisinde namespace namelerini namaspace adı olmadan kullanabilecek, using namespace directive i sayesinde.


        --Nested Namespaces: 
          C# da bir namespace'i  bir diğer namespace'in içerisinde aşağıdaki gibi tanımlayabilirsin: 
          
        namespace namespace_name1 {
           // code declarations 
           namespace namespace_name2 {
              // code declarations
           }
        }
        --> yukarıda görüldüğü gibi iç içe namespace tanımlaması yapabiliyoruz. 
        Nested namespace'in üyelerine dot (.) operatorunu kullanarak erişebilirsin.
    */
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Namespaces In C#.");
            first_space.namespace_c1 fc = new first_space.namespace_c1();
            second_space.namespace_c1 sc = new second_space.namespace_c1();

            fc.func();
            sc.func();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Use Namespaces In Our Code With Using  Directives...");
            //namespace içerisindeki classın objectini doğrudan class adıyla oluşturabiliyoruz. 
            //namespace adını kullanmıyoruz çünki yukarıdaki using directive ile namespace kodumuza ekledik. 
            //böylece namespace adını kullanmadan  direk class adıyla instance ımızı oluşturuyoruz. 
            abc fobj = new abc();
            efg sobj = new efg();

            fobj.func();
            sobj.func();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nested Namespaces...");

            xyz prnt = new xyz();
            wwww chld = new wwww();

            prnt.func();
            chld.func();

            Console.ReadKey();
        }
    }
}
