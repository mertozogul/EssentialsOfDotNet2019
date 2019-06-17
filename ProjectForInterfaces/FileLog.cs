using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInterfaces
{
    public class FileLog : ILog
    {
        //file log log interface'inden türediğinden dolayı loglıyan  bir classdır. Log mesajını dosyaya yazar. Dosyayya yazarak loglama işlemini gerçekleştyirir.Log interface'inden 
        //miras aldığından dolayı loglamak zorundadır.  Yani ılog interface'inin  log methodunu implement etmek zorundadır. 
        //Kendi tarzıyla loglamada serbesttir, bu class dosyaya log atar, ilog interface'inin log methodunu implemente  ederek.
        //implicit implementation (kapalı implementation)
        public void Log(string msgToPrint)
        {
            File.AppendText(@"C:\Log.txt").Write(msgToPrint);
        }

        public void Log(int msgToPrint)
        {
            File.AppendText(@"C:\Log.txt").Write(msgToPrint);
        }
    }
}
