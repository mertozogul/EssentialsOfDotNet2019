using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForOperatorOverloading
{
    public class ClassCaller
    {
        /*
         Operator Overloading Is Static Polymorphizm
            *(Can be overloaded)*Unary Operators (+, -, !, ~, ++, --) --> Unary operator takes one operand. And Unary Operators can be overloaded.  
            *(Can be overloaded)*Binary Operators (+, -, *, /, %) --> Binary operators takes two operand. And Binary operators can be overloaded.
            *(Can be overloaded)*Comparison Operatyors (==, !=, <, >, <=, >=) -->  The comparison operators can be overloaded.
            *(Can not be overloaded)*Conditional Logical Operators (&&, ||) --> The conditional logical operators (şart mantıksal operatorler)  can not be overloaded.
            *(Can not be overloaded)*Assignment Operators (+=, -=, *=, /=, %=, =) --> The assignment operators cannot be overloaded.
            * =, ., ?:, ->, new, is, sizeof, typeof --> These operators cannot be overloaded. 
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Operator Overloading In C#. Operator Overloading is part of Static Polymorphism.");
            Console.WriteLine("");
            Console.WriteLine("");

            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            Box Box3 = new Box();   // Declare Box3 of type Box
            Box Box4 = new Box();   // Declare Box4 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // box 2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            //displaying the Boxes using the overloaded ToString():
            Console.WriteLine("Box 1: {0}", Box1.ToString());
            Console.WriteLine("Box 2: {0}", Box2.ToString());

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // Add two object as follows:
            Box3 = Box1 + Box2;
            Console.WriteLine("Box 3: {0}", Box3.ToString());

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

            //comparing the boxes
            if (Box1 > Box2)
                Console.WriteLine("Box1 is greater than Box2");
            else
                Console.WriteLine("Box1 is not greater than Box2");

            if (Box1 < Box2)
                Console.WriteLine("Box1 is less than Box2");
            else
                Console.WriteLine("Box1 is not less than Box2");

            if (Box1 >= Box2)
                Console.WriteLine("Box1 is greater or equal to Box2");
            else
                Console.WriteLine("Box1 is not greater or equal to Box2");

            if (Box1 <= Box2)
                Console.WriteLine("Box1 is less or equal to Box2");
            else
                Console.WriteLine("Box1 is not less or equal to Box2");

            if (Box1 != Box2)
                Console.WriteLine("Box1 is not equal to Box2");
            else
                Console.WriteLine("Box1 is greater or equal to Box2");

            //Box4 = Box1 + Box2;
            Box4 = Box3;

            if (Box3 == Box4)
                Console.WriteLine("Box3 is equal to Box4");
            else
                Console.WriteLine("Box3 is not equal to Box4");

            Console.ReadKey();
        }
    }
}
