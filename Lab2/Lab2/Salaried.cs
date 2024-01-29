using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Salaried : Employee
    {
        //attributes
        public string Id;
        public string Name;
        public string Address;
        public double Salary;

        //constructor
        public Salaried(string id, string name, string address, double salary)
        {
            Id = id;
            Name = name;
            Address = address;
            Salary = salary;
        }
    }
}
