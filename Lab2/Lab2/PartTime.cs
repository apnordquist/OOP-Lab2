﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class PartTime : Employee
    {
        //attributes
        public string Id;
        public string Name;
        public string Address;
        public double Rate;

        //constructor
        public PartTime(string id, string name, string address, double rate)
        {
            Id = id;
            Name = name;
            Address = address;
            Rate = rate;
        }
    }
}
