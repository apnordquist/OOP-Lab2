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
        private const double regularHours = 40;
        private const double overtimeRate = 1.5;

        //constructor
        public Wages(string id, string name, string address, string phone, long sin, string DOB, string department, double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
        }

        //getters
        public double GetRate()
        { return rate; }
        public double GetHours() 
        { return hours; }

        //setters
        public void SetRate(double rate)
        { this.rate = rate; }
        public void SetHours(double hours)
        { this.hours = hours; }

        //pay method with overtime hours
        public double GetPay()
        {
            if (hours <= regularHours)
                { return hours * rate; }
            else
                { return (regularHours * rate) + ((hours - regularHours) * rate * overtimeRate); }
        }

        //print employee summary
        public string toString()
        {
            return $"ID:{GetId()}\nName: {GetName()}\nAddress: {GetAddress}\nPhone: {GetPhone}\nSIN: {GetSIN()}\nDOB: {GetDOB()}\nDepartment: {GetDepartment()}\nRate: {rate}\nHours: {hours}\nPay: {GetPay()}";
        }
    }
}
