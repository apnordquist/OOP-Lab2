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
    internal class PartTime : Employee
    {
        //attributes
        private double rate { get; set; }
        private double hours { get; set; }

        //parttime constructor
        public PartTime(string id, string name, string address, string phone, long sin, string DOB, string department, double rate, double hours)
        {
            this.rate = rate;
            this.hours = hours;
        }

        public double GetRate()
        { return rate; }
        public double GetHours()
        { return hours; }
        //pay method
        public double GetPay()
        {
            return hours * rate;
        }

        //print employee summary
        public string toString()
        {
            return $"ID:{GetId()}\nName: {GetName()}\nAddress: {GetAddress}\nPhone: {GetPhone}\nSIN: {GetSIN()}\nDOB: {GetDOB()}\nDepartment: {GetDepartment()}\n\nRate: {rate}\nHours: {hours}\nPay: {GetPay()}";
        }
    }
}
