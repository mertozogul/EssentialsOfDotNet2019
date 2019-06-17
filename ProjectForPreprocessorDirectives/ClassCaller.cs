//WE DEFINE SYMBOLIC CONSTANT PI USİNG DEFİNE PREPROCESSOR DIRECTİVE. 
#define MY_VC_V10
#define MY_DEBUG
#define PI

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectForPreprocessorDirectives
{
    /*
           --> C# da Önişlemci Komutları    
           --> Preprocessor Directives In C#
           
         'Preprocessor Directives' derleyiciye emirler verir, ki bu emir ile gerçek derleme başlamadan önce bilgiyi önişlemek ister. Yani amacı gerçek derleme başlamadan önce bilgiyi önişlemektir.
         Bu önişleme işlemini derleyiciye emirler vererek yapıyor. 

         Bütün önişlemci komutları # karakteri ile başlar. Önişlemci Komutları bire kod satırı , kod ifadeleri olmadığından  
         ; ile bitirilmezler. 

          C# derleyicisi ayrı bir önişlemci içermez, fakat emirler sanki C# ayrı bir önişlemci içeriyormuş gibi işlenirler. 

        ********C# da önişlemci emirleri, komutları (preprocessor directives) şartlı derlemeye (conditional compilation) yardım etmek için kullanılırlar.  
        C ve C++ dan farklı olarak önişlemci komutları macroları oluşturmak için kullanılmazlar. 
        Önişlemci Komutu line da sadece emir olmak zorundadır.

        C# da önişlemci komutları:
        Preprocessor Directives in C#
        #define
        --> Sembol diye adlandırılan karakterlerin dizisini dizisini tanımlar. Sembol tanımlar.
        #undef
        --> Sembolü tanımsız hale getirmene imkan sağlar.
        #if
        --> Sembollerin true olarak değerlendirilip değerlendirilmediğini görmek için sembolleri test etmeye   imkan sağlar. 
        #else
        --> if boyunca bileşik şartlı emirleri oluşturmaya imkan sağlar.
        #elif
        --> bileşik şartlı emir oluşturmaya imkan sağlar.
        #endif
        --> şartlı emirin sonunu belirler.
        #line
        -->  bu emir derleyicini satır numarasını değiştirmenize imkan sağlar, aynı zamanda isteğe bağlı olarak 
        --> hatalar ve uyarılar için kullanılan dosyanın adını değiştirmenizede imkan sağlar.
        #error
        --> senin yazdığın kodun belli bir bölgesinden hata oluşturmaya imkan sağlar.
        #warning
        --> senin yazdığın kodun belli bir bölgesinden birinci seviye uyarı oluşturmaya imkan sağlar. 
        #region
        --> Bir kod bloğunu göstermene imkan sağlar. 
        --> senin yazdığın bir kod bloğunu belirlemeni, göstermeni sağlar.
        #endregion
        --> #region bloğunun sonunu işaret eder. 
        
         #define Önişlemci Komutu (The #define Preprocessor)     
           The #define preprocessor yani define önişlemci komutu sembolik sabitler (symbolics constants) oluşturur.
             #define sana bir symbol tanımlaman için imkan sağlar. Ki bu symbol sen bu sembolu #if komutuna ifade olarak geçirip kullandığında, bu sembolü #if directive ine expression olarak geçrdiğinde 
             bu expression bu ifade true olarak değerlendirilir. 
             Sembol tanımlamanın syntaxı aşağıdaki gibidir: 
                #define Symbol
                   Şartlı emir oluşturabilmek için #if directive'ini kullanabilirsin.
                   Şartlı emirler sembol veya sembolleri test etmede kullanılışlıdırlar. Sembol veya semboller şartlı emirler kullanılarak test edildiklerinde yani test edilmelerindeki amaç sembollerin true olarak değerlendirlip 
                   değerlendirlmediğini görmektir.
                   Eğer semboller #if directive'inde true olarak değerlendirilirseler,  compiler (derleyici) #if directive ile bir sonraki directive arasındaki tüm kodları derler, çalıştırır, değerlendirir. 

        Şartlı emirler için syntax: 
          #if symbol [operator symbol]...

        Burada symbol dedğin senin test etmek istediğin symbolun adıdır. 
        Condition oluştururken true yada false uda kullanabilirsin. Aynı zamanda conditionda symbolun başına olumsuzluk önekini de getirebilirsin.
        'operator symbol' bir operator dur ki bu operator,  symbolu değerlendirmede kullanılır.

        Örnek Operatorler: 
         --> == Eşitlik (equality)
         --> != Eşitsizlik (inequality)
         --> && ve (and)
         --> ||veya (or)

        Semboller ve operatorleri parantezler ile gruplıyabilirsin.  Conditional directive #if komutuyla başlar, ve #if komutuyla başlayan bu conditional directive açık olarak #endif directive  ile 
        kapatılmak zorundadır. Yoksa conditional directive oluştururken compiler hatası alırız.

    */
    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Preprocessor Directives In C#..");

            Console.WriteLine("");
            Console.WriteLine("");

#if (PI)
            Console.WriteLine("PI is defined..");
#else
            Console.WriteLine("PI is not defined..");
#endif

            Console.WriteLine("");
            Console.WriteLine("");

#if (PI_2)
            Console.WriteLine("PI_2 is defined..");
#else
            Console.WriteLine("PI_2 is not defined..");
#endif

            Console.WriteLine("");
            Console.WriteLine("");

#if (MY_DEBUG && !MY_VC_V10)
            Console.WriteLine("DEBUG IS DEFINED..");
#elif (!MY_DEBUG && MY_VC_V10)
            Console.WriteLine("VC_V10 IS DEFINED..");
#elif (MY_DEBUG && MY_VC_V10)
            Console.WriteLine("DEBUG AND VC_V10 ARE DEFINED..");
#else
            Console.WriteLine("DEBUG AND VC_V10 ARE NOT DEFINED..");
#endif

            Console.ReadKey();
        }
    }
}
