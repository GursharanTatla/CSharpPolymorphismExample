using System;

namespace PayrollExampleUsingPolymorphism
{
    public enum EmployeeType
    {
        CommissionEmployee, HourlyEmployee, SalariedEmployee, SalaryPlusCommissionEmployee
    }

    // Employee abstract base class
    public abstract class Employee
    {
        // private fields
        private int _employeeId;
        private EmployeeType _empType;
        private string _firstName;
        private string _lastName;


        // properties
        public int EmployeeId
        {
            get { return _employeeId; }
            private set { _employeeId = value; }
        }

        public EmployeeType TypeOfEmployee
        {
            get { return _empType; }
            private set { _empType = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }


        //constructor
        public Employee(int employeeId, EmployeeType empType, string firstName, string lastName)
        {
            EmployeeId = employeeId;
            TypeOfEmployee = empType;
            FirstName = firstName;
            LastName = lastName;
        }


        // abstract method overridden by derived classes
        public abstract double Earnings();     // no implementation here


        // overridden ToString method -- string representation of Employee object
        public override string ToString()
        {
            return $"{FirstName} {LastName} \nEmployee Id: {EmployeeId}" +
                $"\nEmployee Type: {TypeOfEmployee}";
        }
    }
}
