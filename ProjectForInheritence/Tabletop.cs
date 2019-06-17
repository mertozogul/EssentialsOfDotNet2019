﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForInheritence
{
   public  class Tabletop : Rectangle_Table
    {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            double cost;
            //use base class method
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
}
