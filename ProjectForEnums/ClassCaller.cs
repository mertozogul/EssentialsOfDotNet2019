using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForEnums
{
    public static class ClassCalller
    {
        public static void Main(string[] args)
        {
            /*
               Days is a enum namely enumerated type. Each element represent integer value. 
               But when we use enumerated type's identifier as integer value then we must convert it to int type.
               So That 'int WeekDayStart = EnumClass.Days.Mon;' this code takes an compiler error. 
            */
            int WeekDayStart = (int)EnumClass.Days.Mon;
            int WeekDayEnd = (int)EnumClass.Days.Fri;

            Console.WriteLine("Monday: {0}", WeekDayStart);
            Console.WriteLine("Friday: {0}", WeekDayEnd);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("SampleEnum  Values");

            foreach (var identifier in GetValues<EnumClass.SampleEnum>())
            {
                Console.WriteLine("İdentifier: {0}, identifier Integer Value: {1}", identifier, (int)identifier);
            }
            Console.ReadKey();
        }

        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
