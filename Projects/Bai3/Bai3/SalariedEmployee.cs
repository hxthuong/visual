using System;
using System.Collections.Generic;

namespace Bai3
{
    class SalariedEmployee : Employee
    {
        private double salary;
        public SalariedEmployee(string name, double salary, int year, int month, int day): base (name,year,month,day)
        {
            this.salary = salary;
        }
        public string DisplayStat()
        {
            return (base.DisplayStat() + "" + salary);
        }
    }
}
