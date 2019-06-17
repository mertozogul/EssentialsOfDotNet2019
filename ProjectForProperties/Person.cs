using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForProperties
{
    public abstract class Person
    {
        public abstract String Code
        {
            get; 
            set;
        }

        public abstract String Name {
            get;
            set;
        }

        public abstract int Age {
            get;
            set;
        }

        public virtual string VirtualProperty
        {
            get { return "Mert";   }
            set { VirtualProperty = "virtual proeprty";  } 
        }

        public string GetString()
        {
            return "Abstraction In C# From Base Class..";
        }

        public virtual string MyVirtualFunction()
        {
            return "Virtual Function In C# From Base Class..";
        }

        public abstract string FunctionForDerivedClass();
    }
}
