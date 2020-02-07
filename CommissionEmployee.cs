using System;

namespace PayrollExampleUsingPolymorphism
{
    // CommissionEmployee class that extends Employee
    public class CommissionEmployee : Employee
    {
        // private fields
        private double _grossSales;        // gross weekly sales
        private double _commissionRate;    // commission percentage


        // properties
        public double GrossSales
        {
            get { return _grossSales; }

            private set
            {
                if (value < 0)
                    throw new Exception("Gross sales cannot be less than 0");
                else
                    _grossSales = value;
            }
        }

        public double CommissionRate
        {
            get { return _commissionRate; }

            private set
            {
                if (value < 0 || value > 1)
                    throw new Exception("Commission rate cannot be < 0 or > 1");
                else
                    _commissionRate = value;
            }
        }


        // constructor
        public CommissionEmployee(int employeeId, EmployeeType empType, string firstName, string lastName, double grossSales, double commissionRate) : base(employeeId, empType, firstName, lastName)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }


        // calculate earnings; override abstract method Earnings in Employee
        public override double Earnings()
        {
            return GrossSales * CommissionRate;
        }


        // return string representation of CommissionEmployee object
        public override string ToString()
        {
            return $"Commission Employee: {base.ToString()}" +
                $"\nGross Sales: {GrossSales:C}" +
                $"\nCommission Rate: {CommissionRate:P}";
        }
    }
}
