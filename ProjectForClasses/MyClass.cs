using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceHasDifferentName
{
    public class MyClass
    {
        /* Class's Field Member */
        public string myField = string.Empty;

        /* Class's Constructor Member */
        public MyClass()
        {
        }

        /* Class's Method Member */
        public void MyMethod(int parameter1, string parameter2) => Console.WriteLine("First Parameter {0}, second parameter {1}", parameter1, parameter2);

        /* Class's Auto Implemented Property Member */
        /* empty getter  and setter so that this property is auto implemented property. */
        /*  Auto Implemented Property has no backing field. Backing field is returned from propert getter. No Backing Field Is Related With This Property. So That This Property Is 'Auto Implemented Property' */
        /*The backing field will be created automatically by the compiler.*/
        public int MyAutoImplementedProperty { get; set; }
        
        /* Class's Full Property Member */
        /* My Property Field, Class's Field Member */
        private int myPropertyVar;
        public int MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }
        /* Class's Full Property Member */

        /* 
           Bu field'a dışarıdan erişemiyorsun, classCaller Main methoddan bu fieldı göremezsin. 
           Bu fieldı sadece aşağıdaki property'nin getter ve setter'ı ile kullanabilirsin.  
           Tabi senin set ettiğin değeri property kendi isteğine göre değiştirip, fielda kendi istediği değeri set eder.
           Bu şekilde property fieldları encapsulate eder.  Private bir field üyesine dışarıdan, kendi istediği ölçülerde erişim hakkı tanır. 
        */
        private int classFieldWithPrivate; //backing field 

        //bu property'i dışarıya karşı classFieldWithPrivate'ı hep kırpıyor. Az göstermeye çalışıyor. 
        public int propertyEncapField   //bu property backing field ile ilişkilidir.
        {
            get
            {
                return classFieldWithPrivate / 2;
            }

            set
            {
                if (value > 100)
                    classFieldWithPrivate = 100;
                else
                    classFieldWithPrivate = value; ;
            }
        }

    }
}
