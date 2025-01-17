﻿using System;

namespace PayrollExampleUsingPolymorphism
{
    // HourlyEmployee class that extends Employee
    public class HourlyEmployee : Employee
    {
        // fields
        private int _hours;     // hours worked for the week
        private double _wage;  // wage per hour


        // properties
        public int Hours
        {
            get { return _hours; }
            private set
            {
                if (value < 0 || value > 168)
                    throw new Exception("Hours must be >= 0 or <= 168");
                else
                    _hours = value;
            }
        }

        public double Wage
        {
            get { return _wage; }
            private set
            {
                // validate
                _wage = value;
            }
        }


        // constructor
        public HourlyEmployee(int employeeId, EmployeeType empType, string firstName, string lastName, int hours, double wage) : base(employeeId, empType, firstName, lastName)
        {
            Hours = hours;
            Wage = wage;
        }


        // calculate earnings; override Employee's abstract method Earnings
        public override double Earnings()
        {
            if (Hours <= 40)
                return Hours * Wage;
            else
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5);
        }


        // return string representation of HourlyEmployee object
        public override string ToString()
        {
            return $"Hourly Employee: {base.ToString()}" +
                $"\nHours: {Hours}" +
                $"\nWage: {Wage:C}";
        }
    }
}
