using System;
using System.Collections.Generic;

namespace Bai3
{
    class SalesEmployee : SalariedEmployee
    {
        private double commission;
        private double sales;
        public SalesEmployee(string name,double salary,double commission,double sales,int year,int month,int day): base (name,salary,month,day)
        {
            this.commission = commission;
            this.sales = sales;
        }
        public string DisplayStat()
        {
            return (base.DisplayStat() + "" + commission + "" + sales);
        }
    }
}
