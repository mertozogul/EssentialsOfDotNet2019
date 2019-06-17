using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForProperties
{
    public class Stdnt
    {
        /*
             These class fields (methods are also class fields) are private, because of that we can not directly access these fields from outside the class scope. 
             So that we can have properties for accessing these private fields.  
        */

        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        //Declare a Code property  of type string:  
        public string Code
        {
            get {
                return this.code;
            }

            set {
                this.code = value;
            }
        }

        // Declare a Name property of type string:  
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value; 
            }
        }

        // Declare a Age property of type int: 
        public int Age {
            get {
                return this.age;
            }
            set {
                this.age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
}
