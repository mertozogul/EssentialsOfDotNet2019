using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForEnums
{
     /*
        An enumeration is a set of named integer constants. An enumerated type is declared using the enum keyword.
        C# enumerations are value data type. In other words, enumeration contains its own values and cannot inherit or cannot pass inheritance.
        enum <enum_name> {
            enumeration list 
        };
        Where,
        The enum_name specifies the enumeration type name.
        The enumeration list is a comma-separated list of identifiers.
        Each of the symbols in the enumeration list stands for an integer value, one greater than the symbol that precedes it. By default, the value of the first enumeration symbol is 0. For example −
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
     */
    public static class EnumClass
    {
        public enum SampleEnum { Value_0, Value_1, Value_2, Value_3, Value_4, Value_5, Value_6 };
        public enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
    }
}
