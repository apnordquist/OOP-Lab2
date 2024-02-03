using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Wages : Employee
    {
        //attributes
        private double rate;
        private double hours;

        //constructor
        public Wages(string id, string name, string address, string phone, long sin, string DOB, string department, double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
        }

        public double GetRate()
        { return rate; }
        public double GetHours() 
        { return hours; }
        //pay method with overtime hours
        public double GetPay()
        {
            if (hours <= 40)
                { return hours * rate; }
            else
                { return (40 * rate) + ((hours - 40) * rate * 1.5); }
        }

        //print employee summary
        public string toString()
        {
            return $"ID:{GetId()}\nName: {GetName()}\nAddress: {GetAddress}\nPhone: {GetPhone}\nSIN: {GetSIN()}\nDOB: {GetDOB()}\nDepartment: {GetDepartment()}\nRate: {rate}\nHours: {hours}\nPay: {GetPay()}";
        }
    }
}
