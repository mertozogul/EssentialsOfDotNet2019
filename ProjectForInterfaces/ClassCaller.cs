using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInterfaces
{
    public class ClassCaller
    {
        /*
             An interface in C# contains only the declaration of the methods, properties, and events, but not the implementation. 
             It is left to the class that implements the interface by providing implementation for all the members of the interface. 
             Interface makes it easy to maintain a program.
        */

        /*
            Points To Remember: 
              1--> An interface only contains declarations of method, events & properties: Interface method,event, propertieslerin sadece bildirimlerini içerir.
              2--> An interface can be implement implicitly or explicitly: Interface açık (explicitly) , kapalı (implicitly) olarak classlar  tarafından implement edilebilirler.
              3--> An interface cannot include private members. All the members are public by default: Interface private üyeler içeremez. Bütün üyeleri defaultta publicdir.
                Zaten private olması interface mantığına terstir. Interface'in mantığı şudur, sen bildirimler yaparsın bu bildirimleri yapılan uyelere dervide classlar erişir ve implementation yapar. 
                derived Class interface'in bütün üyelerinin implementationu yapmak mecburiyetindedir. Private üyeye erişemezse implementation yapamaz, dolayısıyla compiler hata verir. 
                dolayısıyşa private üyesi olan bir interface miras alınamaz. Miras alınamayan bir interface'inde bir anlamı olmaz. Dolayısıyla interface ve private kavramları ters kavramlardır, birlikte 
                kullanılamazlar.
         */
        public static void Main(string[] args)
        {
            /*
               Now, you can instantiate an object of either the ConsoleLog or FileLog class:
            */
            Console.WriteLine("hello world with interfaces...");
            //normalde türetilmiş classın nesnesini oluşturup o türetilmiş classın nesnesiyle base classın memberlarına erişirsin. 
            ConsoleLog clog = new ConsoleLog();
            FileLog flog = new FileLog();

            //burdaki örnekte direk base classın objectini oluşturuyorsun, fakat ilklendirmeyi türetilmiş class ile yapıyoruz. ilklendirmeyi türetilmiş class ile yapınca method implementationu o türetilmiş class yapmış oluyor.  
            //bu durum normal classlar  arasında da yapılabilir mii ? ? 
            
            ILog c_log = new ConsoleLog();

            ILog f_log = new FileLog();

            //interface için bu durum normal. ilklendirmeyi tiretilmiş class ile yapıp, o derived classın implementationunu kulanmış oluyoruz. 
            //classlar için durum biraz farklı. 

            c_log.Log("log message for console..");
            //access denied diyor bu sebebten dolayı konu dışı olduğu için commentliyorum.
            //f_log.Log("log message for file..");
            
            Console.ReadLine();
        }
    }
}
