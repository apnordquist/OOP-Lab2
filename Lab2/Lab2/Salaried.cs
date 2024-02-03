using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Salaried : Employee
    {
        //attributes
        private double salary;

        //constructor
        public Salaried(string id, string name, string address, string phone, long sin, string DOB, string department, double salary)
        {
            this.salary = salary;
        }

        //fixed weekly salary
        public double GetPay()
        { return salary; }

        public string toString()
        {
            return $"ID:{GetId()}\nName: {GetName()}\nAddress: {GetAddress}\nPhone: {GetPhone}\nSIN: {GetSIN()}\nDOB: {GetDOB()}\nDepartment: {GetDepartment()}\nSalary: {salary}\nPay: {GetPay()}";
        }
    }
}
