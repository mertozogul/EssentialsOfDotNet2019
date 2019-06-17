using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForProperties
{
    public class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        public override string Code { get { return code; }  set { code = value; } }
        public override string Name { get { return name; } set { name = value; } }
        public override int Age { get { return age; } set { age = value; } }

        /// <summary>
        /// we can override virtual property or not.
        /// </summary>
        /// <returns></returns>
        public override string VirtualProperty { get { return code; } set { code = value;  } }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age; 
        }

        /// <summary>
        /// The compiler will give error when i don't override abstract function. Abstract method is overloaded by forced because abstract class doesn't have definition for  abstract method. 
        /// </summary>
        public override string FunctionForDerivedClass()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The compiler does'nt give error when i don't override virtual function. Virtual function is overloaded by optional.
        /// </summary>
        public override string MyVirtualFunction()
        {
            return "Virtual Function In C# From Derived Class..";
        }
    }
}
