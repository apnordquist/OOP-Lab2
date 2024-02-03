/*
Project Name: Lab 2: Inheritance
By: Adam Nordquist
Date: February 3, 2024
Description: Creates a super class that is inherited by three sub classes.
*/
using System.ComponentModel.Design;

namespace Lab2;

internal class Program
{
    static void Main(string[] args)
    {
        //load employees.txt and create list
        List<Employee> employees = new List<Employee>();
        string[] lines = File.ReadAllLines("C:\\Users\\apnor\\CPRG211\\Lab2\\res\\employees.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":"); //split string into list using ':' separator
            string p = parts[0]; //return first item in list (ID)
            /*          Couldn't get it to work with an int, for some reason got an outside of index error?
             *          int firstInt = p[0]; //takes the first digit of ID for sorting
                        switch (firstInt)
                        {
                            case <= 4: //salaried employees
                                employees.Add(new Salaried(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7])));
                                break;
                            case >= 5 and <= 7: //wage employees
                                employees.Add(new Wages(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8])));
                                break;
                            case >= 8: //part time employees
                                employees.Add(new PartTime(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8])));
                                break;
                        }
            */
            char firstChar = p[0];
            switch (firstChar) 
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                    employees.Add(new Salaried(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7])));
                    break;
                case '5':
                case '6':
                case '7':
                    employees.Add(new Wages(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8])));
                    break;
                case '8':
                case '9':
                    employees.Add(new PartTime(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8])));
                    break;
            }
        }
        //output results from methods
        Console.WriteLine("The Average pay of employees is: " + AvgPay(employees));
        Console.WriteLine("The highest paid wage employee is: " + HighWage(employees));
        Console.WriteLine("The lowest paid salary employee is: " + LowSalary(employees));
        Console.WriteLine($"The company is made up of {percentSalary(employees)}% salaried employees, {percentWage(employees)}% wage employees, and {percentPartTime(employees)}% part-time employees.");

        //average pay
        static double AvgPay(List<Employee> employees)
        {
            double SumPay = 0;
            foreach (Employee employee in employees) //go through list and apply method based on subclass
            {
                if (employee is Salaried)
                {
                    SumPay += ((Salaried)employee).GetPay();
                }

                else if (employee is Wages)
                {
                    SumPay += ((Wages)employee).GetPay();
                }

                else if (employee is PartTime)
                {
                    SumPay += ((PartTime)employee).GetPay();
                }
            }
            return SumPay / employees.Count();
        }
        //find highest wages pay
        static string HighWage(List<Employee> employees)
        {
            double HighestWage = 0;
            string HighestWageName = "";
            foreach (Employee employee in employees)
            {
                if (employee is Wages) //only compare wages employees
                {
                    if (((Wages)employee).GetPay() > HighestWage)
                    {
                        HighestWage = ((Wages)employee).GetPay(); //set new highest pay
                        HighestWageName = employee.GetName(); //set new highest name
                    }
                }
            }
            return $"{HighestWageName} with a pay of {HighestWage}.";
        }

        //find lowest salaried pay
        static string LowSalary(List<Employee> employees)
        {
            double LowestSalary = 999999; //arbitary large number
            string LowestSalaryName = "";
            foreach (Employee employee in employees)
            { 
                if (employee is Salaried) //compare only salary employees
                {
                    if (((Salaried)employee).GetPay() < LowestSalary)
                    {
                        LowestSalary = ((Salaried)employee).GetPay(); //set new lowest pay
                        LowestSalaryName = employee.GetName(); //set new lowest name
                    }
                }
            }
            return $"{LowestSalaryName} with a pay of {LowestSalary}.";
        }

        //show percent of employees in each category
        static double percentSalary(List<Employee> employees)
        {
            double numSalary = 0;
            foreach (Employee employee in employees) //go through list and count by type
            {
                if (employee is Salaried)
                    numSalary += 1;
            }
            return numSalary / employees.Count() * 100;
        }

        static double percentWage(List<Employee> employees)
        {
            double numWages = 0;
            foreach (Employee employee in employees) //go through list and count by type
            {
                if (employee is Wages)
                    numWages += 1;
            }
            return numWages / employees.Count() * 100;
        }

        static double percentPartTime(List<Employee> employees)
        {
            double numPartTime = 0;
            foreach (Employee employee in employees) //go through list and count by type
            {
                if (employee is PartTime)
                    numPartTime += 1;
            }
            return numPartTime / employees.Count() * 100;
        }
    }
}