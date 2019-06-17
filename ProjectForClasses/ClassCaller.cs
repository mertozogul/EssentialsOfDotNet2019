using NamespaceHasDifferentName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForClasses
{
    public class ClassCaller
    {
        /*
          Tips For  Namespace:
          --> Namespace is a container for a set of related classes and namespaces. ( bir namespace içersinde yeni bir namespace tanımlayabilirim. )
          --> Namespace is also used to give unique names to classes within the namespace name. Namespace and classes are represented using a dot (.). (FirstNameSpace.FirstClass, SecondNameSpace.FirstClass)
          --> Yukarıda parantez içersinde görüldüğü gibi FirstClass isimli 2 farklı class Namespace adı sayesinde uniqueleşti. 
            namespace CSharpTutorials
            {
                    class MyClass
                    {

                    }
            }
            -->In the above example, the fully qualified class name of MyClass is CSharpTutorials.MyClass.


        */
        /*
           TIPS: 
             1. Field is a class level variable that can holds a value. Generally field  members should  have a private access modifier and used with a property.
             2. Property'ler ile private fieldlerin değerleri  get edilir veya set edilir.
            *****Property And  Private Field  RelationShip******** 
             Property encapsulates a private field. 
             It provides getters (get{}) to retrieve the value of the underlying field and setters (set{}) to set the value of the underlying field. 
             In the above example, _myPropertyVar is a private field which cannot be accessed directly. It will only be accessed via MyProperty. 
             Thus, MyProperty encapsulates _myPropertyVar.
        */

        public static void Main(string[] args)
        {
            MyClass myObj = new MyClass();
            myObj.propertyEncapField = 30;
            Console.WriteLine(myObj.propertyEncapField);
            abc.InnerNameSpace.MyInnnerClass obj1 = new abc.InnerNameSpace.MyInnnerClass();
            ProjectForClasses.SecondInnerNameSpace.MySecondInnnerClass obj2 = new ProjectForClasses.SecondInnerNameSpace.MySecondInnnerClass();
            ProjectForClasses.MyThirdInnnerClass obj3 = new ProjectForClasses.MyThirdInnnerClass();
            MyThirdInnnerClass obj4 = new MyThirdInnnerClass();
        }
    }

    namespace MySecondNameSpace
    {

    }

    namespace abc.InnerNameSpace
    {
        public class MyInnnerClass
        {

        }
    }

    namespace ProjectForClasses.SecondInnerNameSpace
    {
        public class MySecondInnnerClass
        {

        }
    }

    /*
         MyThirdInnnerClass is in sub ProjectForClasses namespace and master ProjectForClasses namespace.
         Master namespace'in içindekileri kullnırken belirtmemize gerek yok. Direk MyThirdInnerClass dersek ilklendirirken classı, compiler hata vermez ve master namespace'in içersindeki  MyThirdInnnerClass ı kabul eder. 
         Fakat ProjectForClasses.MyThirdInnnerClass dersek sub namespace'in içersindeki classsı alır compiler.
         Yani sonuç olarak master namespace'in içerisinde onun adını kullnarak memberlarına erişim olmaz. Sen direk member adı yazdığında o memberı compiler direk master 
         namespace'in  içerisinde arar defaultda. Fakat sen direk master namespace'in içerisindeki sub namespacelerin memberlerına erişiceksen master namespace'in içerisinde namespace adı yaz. 
         Bu durumun dışında hangi namespace'in içerisinde çalışıyorsan o nmaspace içerisindeki memberlara erişmek için p namespace'in adını yazman gerekmiyor. 

        Compiler senin olduğun namespace içersinde sen o namespace'in adını yazmasan da o namespace arar defaulttaa. fakat sen sub namespacelerin memeberlarına erişiceksen, işte o zaman sub namespacelerin adını yazmalısın. 

        Sub namespaceler master namespaceler ile aynı isme sahip olabilir. Neden çünki master namespace'in adını compiler sen master namespacedeyken dikkate almaz. 
    */
    namespace ProjectForClasses
    {
        public class MyThirdInnnerClass
        {

        }
    }

    public class MyThirdInnnerClass
    {

    }
}
