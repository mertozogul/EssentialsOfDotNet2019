using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForOperatorOverloading
{
    class Box
    {
        private double length;    // Length of a box
        private double breadth;   // Breadth of a box
        private double height;    // Height of a box

        //get box's volume value
        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        /* Compare two box object, and return true if these objects are equal or return false if these object are not equal. */
        //lhs --> left hand side (operatorun  sol tarafı) rhs --> right hand side  (operatorun sağ tarafı) 
        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.breadth == rhs.breadth && lhs.height == rhs.height)
            {
                status = true;
            }
            return status;
        }

        /* Compare two box object, and return false if these objects are equal or return true if these object are not equal. */
        //lhs --> left hand side (operatorun  sol tarafı) rhs --> right hand side  (operatorun sağ tarafı) 
        public static bool operator !=(Box lhs, Box rhs)
        {
            //return !(lhs == rhs);
            bool status = false;
            if (lhs.length != rhs.length || lhs.breadth != rhs.breadth || lhs.height != rhs.height)
            {
                status = true;
            }
            return status;
        }

        public static bool operator <(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length < rhs.length && lhs.height < rhs.height
               && lhs.breadth < rhs.breadth)
            {

                status = true;
            }
            return status;
        }

        public static bool operator >(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length > rhs.length && lhs.height >
               rhs.height && lhs.breadth > rhs.breadth)
            {

                status = true;
            }
            return status;
        }

        public static bool operator <=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length <= rhs.length && lhs.height
               <= rhs.height && lhs.breadth <= rhs.breadth)
            {

                status = true;
            }
            return status;
        }

        public static bool operator >=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length >= rhs.length && lhs.height
               >= rhs.height && lhs.breadth >= rhs.breadth)
            {

                status = true;
            }
            return status;
        }

        //ToString methodunu burada override ediyoruz. Demekki built-in ToString() methodu virtual bir method olarak bildirilmiş.
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }
    }
}
