using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForClasses
{
    /*
       A class is like a blueprint of specific object. In the real world, every object has some color, shape and functionalities. 
       For example, the luxury car Ferrari. Ferrari is an object of the luxury car type. The luxury car is a class that specify certain characteristic like speed, color, shape, interior etc. 
       So any company that makes a car that meet those requirements is an object of the luxury car type. 
       For example, every single car of BMW, lamborghini, cadillac are an object of the class called 'Luxury Car'. 
       Here, 'Luxury Car' is a class and every single physical car is an object of the luxury car class.
       Likewise, in object oriented programming, a class defines certain properties, fields, events, method etc. 
       A class defines the kinds of data and the functionality their objects will have.
       A class enables you to create your own custom types by grouping together variables of other types, methods and events.
    */

    /*
        TIPS: 
            1. Field is a class level variable that can holds a value. Generally field  members should  have a private access modifier and used with a property.
            2. Property'ler ile private fieldlerin değerleri  get edilir veya set edilir.
        *****Property And  Private Field  RelationShip******** 
            Property encapsulates a private field. 
            It provides getters (get{}) to retrieve the value of the underlying field and setters (set{}) to set the value of the underlying field. 
            In the above example, _myPropertyVar is a private field which cannot be accessed directly. It will only be accessed via MyProperty. 
            Thus, MyProperty encapsulates _myPropertyVar.
    */
    public class Classes
    {
        /*
             From C# 3.0 onwards, if you don't want to make some logic in property's getter and setter and then property declaration has been made easy.   
             These properties are called 'Auto İmplemented Property'
        */

        /* Class's Auto Implemented Property Member */
        /* empty getter  and setter so that this property is auto implemented property. */
        /*  Auto Implemented Property has no backing field. Backing field is returned from propert getter. No Backing Field Is Related With This Property. So That This Property Is 'Auto Implemented Property' */
        /*The backing field will be created automatically by the compiler.*/
        public int MyAutoImplementedProperty { get; set; }

        private int _myPropertyVar;

        public int MyProperty
        {
            get
            {
                return _myPropertyVar / 2;
            }

            set
            {
                if (value > 100)
                    _myPropertyVar = 100;
                else
                    _myPropertyVar = value; ;
            }
        }
    }
}
