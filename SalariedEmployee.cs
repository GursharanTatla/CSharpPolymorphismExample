using System;

namespace PayrollExampleUsingPolymorphism
{
    // SalariedEmployee class that extends Employee
    public class SalariedEmployee : Employee
    {
        // field
        private double _weeklySalary;


        // property
        public double WeeklySalary
        {
            get { return _weeklySalary; }
            private set
            {
                if (value < 0)
                    throw new Exception("Weekly salary must be > 0");
                else
                    _weeklySalary = value;
            }
        }

        // constructor
        public SalariedEmployee(int employeeId, EmployeeType empType, string firstName, string lastName, double weeklySalary) : base(employeeId, empType, firstName, lastName)
        {
            WeeklySalary = weeklySalary;
        }


        // calculate earnings; override abstract method Earnings in Employee
        public override double Earnings()
        {
            return WeeklySalary;
        }


        // return string representation of SalariedEmployee object
        public override string ToString()
        {
            return $"Salaried Employee: {base.ToString()}" +
                $"\nWeekly Salary: {WeeklySalary:C}";
        }
    }
}
