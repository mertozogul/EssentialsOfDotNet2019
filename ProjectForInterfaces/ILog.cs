using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInterfaces
{
    /*
      Now, different classes can implement ILog by providing an implementation of the Log() method, for example, 
      the ConsoleLog class logs the string on the console whereas FileLog logs the string into a text file. 
    */
    interface ILog
    {
        void Log(string msgToLog);

        void Log(int msgToLog);
    }
}
