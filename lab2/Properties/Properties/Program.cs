﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Employee
    {
        private int _EmpId;
        private string _EmpName;

        //Public Properties
        public int EmpId
        {
            //The Set Accessor is used to set the _EmpId private variable value
            set
            {
                _EmpId = value;
            }
            //The Get Accessor is used to return the _EmpId private variable value
            get
            {
                return _EmpId;
            }
        }
        public string EmpName
        {
            //The Set Accessor is used to set the _EmpName private variable value
            set
            {
                _EmpName = value;
            }
            //The Get Accessor is used to return the _EmpName private variable value
            get
            {
                return _EmpName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //We cannot access the private data members
            //So, using public properties (SET Accessor) we are setting 
            //the values of private data members
            employee.EmpId = 101;
            employee.EmpName = "Anik";

            //Using public properties (Get Accessor) we are Getting 
            //the values of private data members
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee id:" + employee.EmpId);
            Console.WriteLine("Employee name:" + employee.EmpName);
            Console.ReadKey();
        }
    }
}