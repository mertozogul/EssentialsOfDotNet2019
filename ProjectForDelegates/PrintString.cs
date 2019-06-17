using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

//delegate declaration
public delegate void printString(string s);

namespace ProjectForDelegates
{
    public class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;
        
        //this method prints to the console
        public static void PrintToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("D:/message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        //this method takes the delegate  as parameter and uses it to call the methods as required.
        public static void sendString(printString ps)
        {
            ps("Hello World"); 
        }
    }
}
