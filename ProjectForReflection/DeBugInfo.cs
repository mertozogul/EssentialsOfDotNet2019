﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForReflection
{
    //a custom attribute BugFix to be assigned to a class and its members
    [AttributeUsage(
       AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true)]
    public class DeBugInfo : Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message; 

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d; 
        }

        public int BugNo {
            get {
                return this.bugNo;
            }
        }

        public string Developer {
            get {
                return this.developer;
            }
        }

        public string LastReview {
            get {
                return this.lastReview;
            }
        }

        public string Message {
            get {
                return this.message;
            }
            set {
                this.message = value;
            }
        }
    }
}
