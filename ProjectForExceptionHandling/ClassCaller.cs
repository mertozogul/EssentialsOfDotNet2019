using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForExceptionHandling
{
    /*
        An exception is a problem  that arises during the execution of a program.  C#  exception is a response to an exceptional circumstance,  that 
        arises while a program is running, such as an attempt  to divide by zero.
        
        C# exception handling is built upon four keywords: try, catch, finally, and throw.

        finally --> The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. For example, if you open a file, it must be a closed whether an exception is raised  or not.
        Namely in this situation you must close file in finally block. 
       
        try/catch block syntax : 
        
           try {
                // statements causing exception
                //buraya hata fırlatabilecek kod bloğunu yazıyoruz.  Buraya yazılan kod bloğu icrası sırasında hata oluşabilecek  bir kod bloğudur. 
            } catch( ExceptionName e1 ) {
               // error handling code
            } catch( ExceptionName e2 ) {
               // error handling code
            } catch( ExceptionName eN ) {
               // error handling code
            } finally {
               // statements to be executed
               //muhakkak çalıştırılacak code bloğu... Hata thrown olsa da olmasada bir başka deyişle catch e düşülse de düşülmese de  bu finally kod bloğu çalışır. 
            }

        Aşağıdaki tablo önceden tanımlanmış exception classlarının bir kaçını sağlar, gösterir.  Ki bu önceden tanımlanmış exception  classları System.SystemException classından türetilirler. 
        Aşağıda System.SystemException exception classından türetilen  exception class örnekleri mevcuttur.
        
        Exception Class Task Number: Exception Class Description
        --------------------------------------------------------
        Not --> Aşağıdaki exception classlarının  tümü System.SystemException classından miras almıştır veya türemiştir.
        1--> System.IO.IOException:  Handles I/O errors. 
        2--> System.IndexOutOfRangeException: Array'in index aralığı dışında bir index ile onun elemanına  erişilmek istendiğinde fırlatılan hatayı işleyen exception classıdır.
        3--> System.ArrayTypeMismatchException: Array'in tipi ile uyuşmayan bir tipdeki değer array'e atanmak istendiğinde tip uyuşmazlığı hatası fırlatılır. Bu tip uyuşmazlığı hatalarınıda bu exception classı işler.
        4--> System.NullReferenceException: Null bir objeyi referans ettiğinde (refrans olarak aldığında, veya kod içinde kullandığında) oluşabilecek hataları işleyen bir exception classıdır.   
        5--> System.DivideByZeroException: Bölüneni sıfır ile bölmekten oluşacak hataları işleyen bir exception classıdır. 
        6--> System.InvalidCastException: type casting hatalarını işler.
        7--> System.OutOfMemoryException: Yetersiz bellek hatalarında fırlatılan hataları işler. Mesela örnek olarak int bir alana double bir alandaki değeri  atadığımızdaki throw olan hatayı bu exception classı işler. 
        8--> System.StackOverflowException: Yığın veri yapısının taşması sonucunda oluşan hataları işleyen classdır.
    */

    public class ClassCaller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Exception Handling In C#..");
            Console.WriteLine("");
            Console.WriteLine("");

            /*Example 1*/
            //predefined exception is occurred and then predefined exception class handles this error..
            DivNumbers d = new DivNumbers();
            //d.division(25,0);
            //d.division(25, 5);


            /*Example 2*/
            //// Creating User-Defined Exceptions
            //Temperature temp = new Temperature();
            ////temp değeri classın içerisinde sıfır olduğundan dolayı hata throw edilicek. Custom exception classı ile..  hata throw edildiğinden dolayı  akış catch e düşücek, bende kendi yazdığım exception classı ile 
            ////hatayı yakalıcam. 
            //try
            //{
            //    temp.ShowTemp();
            //}
            ////catch (Exception) buraya exception classından miras alan kendi own exception classımı yazıcam.  bu şekilede own class ile throw edilmiş hatayı catch edicem yakalıcam. 
            //catch (MyCustomExceptionClass m)
            //{
            //    Console.WriteLine("MyCustomExceptionClass : {0}", m.Message);
            //}

            /*Example 3*/
            Temp t = new Temp();
            try
            {
                t.ShowTemp();
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine(exp.Message);
                throw exp;
            }
            catch (MyCustomExceptionClass exp)
            {
                Console.WriteLine(exp.Message);
                throw exp;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                throw exp;
            }
            finally
            {
                Console.WriteLine("try-catch code block is compiled...");
            }
            

            //throw new Exception("Hello Exception....");

            Console.ReadKey();
        }
    }
}
