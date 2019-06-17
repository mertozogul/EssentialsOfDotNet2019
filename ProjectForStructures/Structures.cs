using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForStructures
{
    /*
            In C#, a structure is a value type data type. 
            Structures are used to represent a record.
            The struct statement defines a new data type, with more than one member for your program.
            Structures in C# are quite different from that in traditional C or C++.
            --Structures can have methods, fields, indexers, properties, operator methods, and events.
            --Structures can have defined constructors, but not destructors. However, you cannot define a default constructor for a structure. The default constructor is automatically defined and cannot be changed.
            --Unlike classes, structures cannot inherit other structures or classes.
            --Structures cannot be used as a base for other structures or classes.
            --No Inheritance.. 
            --Structure members cannot be specified as abstract, virtual, or protected.
            --When you create a struct object using the New operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the New operator.
            --If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.

            Classes and Structures have the following basic differences −
            **classes are reference types and structs are value types
            **structures do not support inheritance
            **structures cannot have default constructor
    */

    public struct Books
    {
        /*
          *We cannot declare struct members as protected, abstract, virtual 
            protected int abc;
         *We cannot declare default constructor for our struct
            public void Book() {}
        */
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void setValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };
}
