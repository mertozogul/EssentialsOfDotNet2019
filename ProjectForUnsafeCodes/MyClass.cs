using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForUnsafeCodes
{
    public class MyClass
    {
        public string ReturnMessage()
        {
            return "Happy Coding!";
        }

        //this method get value type variable as parameter 
        public void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine("changed value type variable value to {0} in method.", x);
        }

        public void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        public void ChangeStringReferenceTypeVariableValue(ref String str)
        {
            str = "Reference Type String Value Is Changed In Method";
        }
    }
}
