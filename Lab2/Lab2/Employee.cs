using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Employee
    {
        //attributes
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string DOB;
        private string department;

        //default
        public Employee()
        {

        }

        //constructor
        public Employee(string id, string name, string address, string phone, long sin, string DOB, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.DOB = DOB;
            this.department = department;
        }

        public string GetId()
        { return id; }
        public string GetName() 
        { return name; }    
        public string GetAddress() 
        { return address; }
        public string GetPhone() 
        { return phone; }
        public long GetSIN() 
        { return sin; }
        public string GetDOB() 
        {  return DOB; }
        public string GetDepartment() 
        {  return department; }

        //print employee summary
        public string toString()
        {
            return $"ID:{id}\nName: {name}\nAddress: {address}\nPhone: {phone}\nSIN: {sin}\nDOB: {DOB}\n, Department: {department}\n";
        }
    }
}
