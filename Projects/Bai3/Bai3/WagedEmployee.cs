using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class WagedEmployee : Employee
    {
        private double wage,hours;
        public WagedEmployee
            ( string name,double hours,double wage,int year,int month,int day) : base(name,year,month,day)
            {
            this.wage = wage;
            this.hours = hours;
        }
        public string DisplayStat()
        {
            return (base.DisplayStat()+ "" + wage +""+hours+ CalcPay());
        }
        public override double CalcPay()
        {
            return wage* hours;
        }
    }
}
