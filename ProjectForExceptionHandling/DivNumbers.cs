using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForExceptionHandling
{
    public class DivNumbers
    {
        int result;

        public DivNumbers()
        {
            result = 0;
        }
        
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
                /*
                    num2 sıfır olduğunda throw işlemi otomotik olarak yapılmaktadır.
                    yani aşağıdaki işlem otomatik sistem tarafından yapılıyor..
                     throw (new DivideByZeroException());
                */
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Excetion caught: {0}", e.Message);
            }
            finally
            {
                //catch ile hata fırlatmasada fırlatsada bu finally blokuna kod düşer ve sonuç ekrana yazdırılır.
                Console.WriteLine("Result: {0}", result);
            }
        }
    }
}
