using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForReflection
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : Attribute
    {
        public readonly string Url;
        private string topic;

        public string Topic  // Topic is a named parameter namely optional parameter hence it is not passsed to the constructor method.  
        {
            get {
                return this.topic;
            }
            set {
                this.topic = value; 
            }
        }

        public HelpAttribute(string url) // url is positional parameter
        {
            this.Url = url;
        } 
    }

    [HelpAttribute("Information on the class MyClass that is stored with attibute that it obtained with reflection objects..")]
    class MyClass
    {

    }
}
