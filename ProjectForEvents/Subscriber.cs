using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForEvents
{
    public class Subscriber
    {
        //event handler of subscriber class. THis method is called from delegate which is in publisher class and associated with event.
        //this class accept event which is in publisher class. 
        public static string WelcomeUser(string UserName)
        {
            return "Welcome " + UserName; 
        }
    }
}
