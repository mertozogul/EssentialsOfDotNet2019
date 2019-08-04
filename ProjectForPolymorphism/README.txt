--C# Polymorphism--

Polymorphism static veya  dynamic olabilir. Static Polymorphism de fonksiyona verilen cevap compile (derleme) zamanında belirlenir, dynamic polymorphimd'e fonksiona verilen cevap run-time (koşma zamanında) belirlenir.
            
The word polymorphism means having many forms. In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'.
Polymorphism can be static or dynamic. In static polymorphism, the response to a function is determined at the compile time. In dynamic polymorphism, it is decided at run-time : 
           
Static Polymorphism 
    Compile time da gerçekleşen  Object ile fonksyionun bağlanma mekanizması EARLY (ERKEN) BINDING (BAĞLANMA) denir. Aynı zamanda static binding de denir. C# static polymorphism'i 
    sağlamak için 2 tane teknik sağlar. 
    Bunlar: 
        --> Fonksyion Aşırı Yüklemesi
        --> Operator Aşırı Yüklemesi
    Operator Aşırı yüklemesi diğer chapterın konusu.
               
The mechanism of linking a function with an object during compile time is called early binding. It is also called static binding. C# provides two techniques to implement static polymorphism. 
They are −
    Function overloading
    Operator overloading
We discuss operator overloading in next chapter.

Function Overloading: 
    Âynı scope'da aynı isimde ki fonksyion için birden fazla implementation olabilir.  Fonksyion tanımlamaları (dec + impl) birbirlerinden farklı olmak zorundadırlar.  Aynı isimdeki fonksyionlar  
    bu farklılığı argumenler ile yapmak zorundadırlar. Arguman listesinin ya sayısı yada listedeki argumenlerin herhangi birisini tipi farklı olmak zorundadır.
    *******sadece return typeları farklı olan fonksyion bildirimlerini sen aşırı yükliyemezsin. Yani sadece return typeları farklı olan aynı isimdeki fonksyionları aşırı yükliyemezsin, overload sadece return type
    ın farklı olması yeterli değildir. 

You can have multiple definitions for the same function name in the same scope. 
The definition of the function must differ from each other by the types and/or the number of arguments in the argument list. 
You cannot overload function declarations that differ only by return type.

Dynamic Polymorphism (Run Time Polymorphism / Late Binding / Dynamic Binding) : 
C# sana abstract classlar oluşturmanı sağlar, bu konuda sana imkan sağlar, ki bu abstract classlar interface'in partial class uygulamasını sağlarlar. interface'i bir partial class gibi kullanılmasını sağlarlar.
Bu uygulama türetülmiş (derived) sınıf abstract classdan miras aldığında tamamlanır. Abstract classlar abstract methodlar içerirler ki bu 
abstract methodlar türetilmiş classlar tarafından kendilerine özgü, tanımlanırlar implement edilirler. 

*****Türetilmiş sınıflar daha özel fonksiyonelliğe sahiptir. 
* The derived classes have more specialized functionality. 
Abstract class kuralları: 
    1--> Abstract classlar'ın herhangi bir instance'ı oluşturulamazlar. 
    2--> Sen abstract bir methodun bildirimini abstract classın dışarısında yapamazsın.
    3--> Sen bir classı 'sealed' olarak tanımladığın zaman o class diğer classlar tarafından miras alınamaz.  dolayısıyla abstract classların bildirimini sealed olarak yapamazsın.
    Çünki abstract classlar abstaract method bildirimi içerir. Bu abstarct methodların tanımlanmasını derived classlar yapar. Dolayısıyla tek baŞına bir abstract class aslında miras alınmazsa hiç bir işe yaramaz. 
    Çünki sadece fonksiyonların bildirimini içerir. Tüm bu sebeblerden dolayı abstract class selad olarak bildirilemezler.

Dynamic Polymorphism denince aklımıza abstract class, abstract method and virtual methodlar gelicek.
*******Deep Note*********
Sen bir class ın içerisinde bir fonksiyon implementation'ı içerebilirsin normal fonksiyon tanımlaması içerdiğinde bu methodu bu classdan miras alan  
türetilmiş classların kendilerine özgü bir şekilde implementation yapmalarını istersin. 
İşte bu tür durumlarda virtual fonksyionları kullanırsınız. Virtual fonksyionlar  farklı türetilmiş classlarda 
farklı olarak implementation edilirler ve bu fonksiyonların hangisinin çağrıldığı run time da (dynamic polyporphism) belli olur.
*******Deep Note*********
           
*****DON'T FORGET THIS SENTENCE****
    --Dynamic Polymorphism is implemented by abstract classes and virtual functions. 
    C# DA DYNAMİC POLYPORPHISM ABSTRACT CLASSLAR VE VIRTUAL FONKSİYONLAR KULLANILARAK UYGULANIR. 
****DON'T FORGET THIS SENTENCE****
         
    Summary: Abstract classlar sadece miras alınmak için var olan classlardır, yani derived classlar ile kullanılabilir hale gelebilirler.So Abstract classlar sealed veya static olarak tanımlananmazlar.
    Eğer abstract class sealed veya static olarak tanımlanırsa compiler hata vericektir. 
    Reminding_1: Bir class sealed (kelime anlamı: mühürlenmiş) olarak tanımlanırsa ondan hiç bir class miras alamaz. 
    Reminding_2: Bir class static olarak tanımlanırsa o classın instance ı oluşturulmadan  o classın memberlarına erişim  sağlanabilir.