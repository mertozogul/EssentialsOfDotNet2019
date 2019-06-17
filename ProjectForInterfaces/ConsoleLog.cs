using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInterfaces
{
    public class ConsoleLog : ILog
    {
        //bir class eğer bir interface'den miras alıyor ise o interface'de bulunan bütün üyelerin implementation ı yapmak mecburyetindedir. Yoksa compiler hata verir.
        //console log log interface'inden türediğinden dolayı loglıyan  bir classdır. Console'a log yazar.
        //implicit implementation
        public void Log(float msgToPrint)
        {
            Console.WriteLine(msgToPrint);
        }

        //Implement interface explicitly: Interface açık olarak implement et.
        //Yani açık olarak interface'in adını prefix yaparak, onun adını kullanarak interface'in log methodunu implement ediyorum. Açıkca bu method bu interface'in diyorum. 
        void ILog.Log(string msgToLog) //explicit implementation
        {
            Console.WriteLine("-->" + msgToLog);
        }

        void ILog.Log(int msgToLog) //explicit implementation
        {
            Console.WriteLine(msgToLog);
        }



        /*
         
         Explicit implementation is useful when class is implementing multiple interface thereby it is more readable and eliminates the confusion. 
         It is also useful if interfaces have same method name coincidently.
         Açıklama: 
          Açık açık implement etmek eğer class birden fazla interface den miras aldığı durumlarda çok kullanışlı olur.  Bu şekilde çok daha okunur olur ve karmaşıklığı ortadan kaldırır.
          Aynı zamanda interface de ve class da aynı isimde methodlar var ise (tesadüfen olur, yukarıda örneğini gerçekleştirdik.) yine bu durumda da explicit implementation çok kulanışlı oluır.


         */
    }
}
